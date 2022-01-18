using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetarsConsole.Migrations
{
    public partial class fixit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Metars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObservationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longtitude = table.Column<double>(type: "float", nullable: false),
                    TempC = table.Column<double>(type: "float", nullable: false),
                    DewPointC = table.Column<double>(type: "float", nullable: false),
                    WindDirDegree = table.Column<int>(type: "int", nullable: false),
                    WindSpeedKnots = table.Column<int>(type: "int", nullable: false),
                    VisibilityStatuteMi = table.Column<double>(type: "float", nullable: false),
                    AltimeterInHg = table.Column<double>(type: "float", nullable: false),
                    SeaLevelPressureMb = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FlightCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreeHrPressureTEndencyMb = table.Column<double>(type: "float", nullable: false),
                    MaxTC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinTC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecipIn = table.Column<double>(type: "float", nullable: false),
                    Pcp6hrIn = table.Column<double>(type: "float", nullable: false),
                    MetarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevationM = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualityFlags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityFlags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QualityFlags_Metars_MetarId",
                        column: x => x.MetarId,
                        principalTable: "Metars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkyConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkyCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudBaseFtAng = table.Column<int>(type: "int", nullable: false),
                    MetarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkyConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkyConditions_Metars_MetarId",
                        column: x => x.MetarId,
                        principalTable: "Metars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QualityFlags_MetarId",
                table: "QualityFlags",
                column: "MetarId");

            migrationBuilder.CreateIndex(
                name: "IX_SkyConditions_MetarId",
                table: "SkyConditions",
                column: "MetarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualityFlags");

            migrationBuilder.DropTable(
                name: "SkyConditions");

            migrationBuilder.DropTable(
                name: "Metars");
        }
    }
}
