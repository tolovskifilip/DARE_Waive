(function(window, undefined) {
  var dictionary = {
    "3495ed23-ed54-40d9-8159-b9170cdc8216": "Public-Overview",
    "bcecf7ac-c599-4539-bd1f-860a5e3c991c": "Public-Details",
    "d12245cc-1680-458d-89dd-4f0d7fb22724": "Expert-Overview",
    "fd4549b0-b339-444d-b10a-1314b391be3d": "Expert-Details",
    "f39803f7-df02-4169-93eb-7547fb8c961a": "Template 1",
    "bb8abf58-f55e-472d-af05-a7d1bb0cc014": "default"
  };

  var uriRE = /^(\/#)?(screens|templates|masters|scenarios)\/(.*)(\.html)?/;
  window.lookUpURL = function(fragment) {
    var matches = uriRE.exec(fragment || "") || [],
        folder = matches[2] || "",
        canvas = matches[3] || "",
        name, url;
    if(dictionary.hasOwnProperty(canvas)) { /* search by name */
      url = folder + "/" + canvas;
    }
    return url;
  };

  window.lookUpName = function(fragment) {
    var matches = uriRE.exec(fragment || "") || [],
        folder = matches[2] || "",
        canvas = matches[3] || "",
        name, canvasName;
    if(dictionary.hasOwnProperty(canvas)) { /* search by name */
      canvasName = dictionary[canvas];
    }
    return canvasName;
  };
})(window);