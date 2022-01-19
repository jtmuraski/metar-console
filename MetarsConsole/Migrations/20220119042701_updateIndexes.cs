using Microsoft.EntityFrameworkCore.Migrations;

namespace MetarsConsole.Migrations
{
    public partial class updateIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RawText",
                table: "Metars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Metars_RawText",
                table: "Metars",
                column: "RawText",
                unique: true,
                filter: "[RawText] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Metars_RawText",
                table: "Metars");

            migrationBuilder.AlterColumn<string>(
                name: "RawText",
                table: "Metars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
