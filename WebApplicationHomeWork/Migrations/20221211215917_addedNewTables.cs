using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class addedNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "conservator",
                newName: "Role");

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTarihi",
                table: "Ogrenci",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OdaId",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeliId",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EvAdresi",
                table: "conservator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IbanNo",
                table: "conservator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelefonNo",
                table: "conservator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Yatak",
                columns: table => new
                {
                    YatakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YatakSırası = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yatak", x => x.YatakId);
                });

            migrationBuilder.CreateTable(
                name: "Oda",
                columns: table => new
                {
                    OdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YatakId = table.Column<int>(type: "int", nullable: false),
                    OdaTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oda", x => x.OdaId);
                    table.ForeignKey(
                        name: "FK_Oda_Yatak_YatakId",
                        column: x => x.YatakId,
                        principalTable: "Yatak",
                        principalColumn: "YatakId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_OdaId",
                table: "Ogrenci",
                column: "OdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_VeliId",
                table: "Ogrenci",
                column: "VeliId");

            migrationBuilder.CreateIndex(
                name: "IX_Oda_YatakId",
                table: "Oda",
                column: "YatakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_Oda_OdaId",
                table: "Ogrenci",
                column: "OdaId",
                principalTable: "Oda",
                principalColumn: "OdaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_conservator_VeliId",
                table: "Ogrenci",
                column: "VeliId",
                principalTable: "conservator",
                principalColumn: "VeliId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_Oda_OdaId",
                table: "Ogrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_conservator_VeliId",
                table: "Ogrenci");

            migrationBuilder.DropTable(
                name: "Oda");

            migrationBuilder.DropTable(
                name: "Yatak");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_OdaId",
                table: "Ogrenci");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_VeliId",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "KayitTarihi",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "OdaId",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "VeliId",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "EvAdresi",
                table: "conservator");

            migrationBuilder.DropColumn(
                name: "IbanNo",
                table: "conservator");

            migrationBuilder.DropColumn(
                name: "TelefonNo",
                table: "conservator");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "conservator",
                newName: "MyProperty");
        }
    }
}
