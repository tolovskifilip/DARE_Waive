using Microsoft.EntityFrameworkCore.Migrations;

namespace DARE_Waive.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AktivierungsDokumente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AktivierungsDokumente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MasterData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlanungsDatenAnlagen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanungsDatenAnlagen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RedispatchingBedarfe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedispatchingBedarfe", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AktivierungsDokumente");

            migrationBuilder.DropTable(
                name: "MasterData");

            migrationBuilder.DropTable(
                name: "PlanungsDatenAnlagen");

            migrationBuilder.DropTable(
                name: "RedispatchingBedarfe");
        }
    }
}
