﻿var width = 960,
    height = 500,
    focused = null,
    geoPath;

var svg = d3.select("MapDiv")
    .append("svg")
    .attr("width", width)
    .attr("height", height);

svg.append("rect")
    .attr("class", "background")
    .attr("width", width)
    .attr("height", height);

var g = svg.append("g")
    .append("g")
    .attr("id", "states");


d3.json("./dataBundesLander.json", function (collection) {

    var bounds = d3.geo.bounds(collection),
        bottomLeft = bounds[0],
        topRight = bounds[1],
        rotLong = -(topRight[0] + bottomLeft[0]) / 2;
    center = [(topRight[0] + bottomLeft[0]) / 2 + rotLong, (topRight[1] + bottomLeft[1]) / 2],

        //default scale projection
        projection = d3.geo.albers()
            .parallels([bottomLeft[1], topRight[1]])
            .rotate([rotLong, 0, 0])
            .translate([width / 2, height / 2])
            .center(center),

        bottomLeftPx = projection(bottomLeft),
        topRightPx = projection(topRight),
        scaleFactor = 1.00 * Math.min(width / (topRightPx[0] - bottomLeftPx[0]), height / (-topRightPx[1] + bottomLeftPx[1])),

        projection = d3.geo.albers()
            .parallels([bottomLeft[1], topRight[1]])
            .rotate([rotLong, 0, 0])
            .translate([width / 2, height / 2])
            .scale(scaleFactor * 0.975 * 1000)
            //.scale(4*1000)  //1000 is default for USA map
            .center(center);

    geoPath = d3.geo.path().projection(projection);

    var graticule = d3.geo.graticule()
        .step([1, 1]);

    g.append("path")
        .datum(graticule)
        .attr("class", "graticuleLine")
        .attr("d", geoPath);

    g.selectAll("path.feature")
        .data(collection.features)
        .enter()
        .append("path")
        .attr("class", "feature")
        .attr("d", geoPath)
        .on("click", clickPath);

    console.log("d3.json: bounds = " + bounds);
    console.log("d3.json: bottomLeft = " + bottomLeft);
    console.log("d3.json: topRight = " + topRight);
    console.log("d3.json: center = " + center);
    console.log("d3.json: projection(center) = " + projection(center));
    console.log("d3.json: projection(bottomLeft) = " + projection(bottomLeft));
    console.log("d3.json: projection(topRight) = " + projection(topRight));
    console.log("d3.json: topRightPx = " + topRightPx);
    console.log("d3.json: bottomLeftPx = " + bottomLeftPx);
    console.log("d3.json: scaleFactor x axis = " + width / (topRightPx[0] - bottomLeftPx[0]));
    console.log("d3.json: scaleFactor y axis = " + height / (-topRightPx[1] + bottomLeftPx[1]));
    console.log("d3.json: scaleFactor = " + scaleFactor);
});


function clickPath(d) {
    var x = width / 2,
        y = height / 2,
        k = 1,
        name = d.properties.NAME_1;

    g.selectAll("text")
        .remove();
    if ((focused === null) || !(focused === d)) {
        var centroid = geoPath.centroid(d),
            x = +centroid[0],
            y = +centroid[1],
            k = 1.75;
        focused = d;

        g.append("text")
            .text(name)
            .attr("x", x)
            .attr("y", y)
            .style("text-anchor", "middle")
            .style("font-size", "8px")
            .style("stroke-width", "0px")
            .style("fill", "black")
            .style("font-family", "Times New Roman")
            .on("click", clickText);
    } else {
        focused = null;
    };

    g.selectAll("path")
        .classed("active", focused && function (d) { return d === focused; });

    g.transition()
        .duration(1000)
        .attr("transform", "translate(" + (width / 2) + "," + (height / 2) + ")scale(" + k + ")translate(" + (-x) + "," + (-y) + ")")
        .style("stroke-width", 1.75 / k + "px");
}


function clickText(d) {
    focused = null;
    g.selectAll("text")
        .remove();
    g.selectAll("path")
        .classed("active", 0);
    g.transition()
        .duration(1000)
        .attr("transform", "scale(" + 1 + ")translate(" + 0 + "," + 0 + ")")
        .style("stroke-width", 1.00 + "px");
}