using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class updatedAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ogrenci",
                newName: "OgrenciId");

            migrationBuilder.AddColumn<string>(
                name: "KapiSifre",
                table: "Ogrenci",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sifre",
                table: "Ogrenci",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KapiSifre",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "Sifre",
                table: "Ogrenci");

            migrationBuilder.RenameColumn(
                name: "OgrenciId",
                table: "Ogrenci",
                newName: "Id");
        }
    }
}
