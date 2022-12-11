using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class setedAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oda_Yatak_YatakId",
                table: "Oda");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_Oda_OdaId",
                table: "Ogrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_conservator_VeliId",
                table: "Ogrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_departments_BolumId",
                table: "Ogrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_schools_OkulId",
                table: "Ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yatak",
                table: "Yatak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oda",
                table: "Oda");

            migrationBuilder.RenameTable(
                name: "Yatak",
                newName: "beds");

            migrationBuilder.RenameTable(
                name: "Ogrenci",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Oda",
                newName: "rooms");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_VeliId",
                table: "students",
                newName: "IX_students_VeliId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_OkulId",
                table: "students",
                newName: "IX_students_OkulId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_OdaId",
                table: "students",
                newName: "IX_students_OdaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_BolumId",
                table: "students",
                newName: "IX_students_BolumId");

            migrationBuilder.RenameIndex(
                name: "IX_Oda_YatakId",
                table: "rooms",
                newName: "IX_rooms_YatakId");

            migrationBuilder.AddColumn<int>(
                name: "OdemeId",
                table: "conservator",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_beds",
                table: "beds",
                column: "YatakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rooms",
                table: "rooms",
                column: "OdaId");

            migrationBuilder.CreateTable(
                name: "announcements",
                columns: table => new
                {
                    DuyuruId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_announcements", x => x.DuyuruId);
                });

            migrationBuilder.CreateTable(
                name: "foods",
                columns: table => new
                {
                    YemekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foods", x => x.YemekId);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    OdemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OdemeTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.OdemeId);
                    table.ForeignKey(
                        name: "FK_payments_conservator_VeliId",
                        column: x => x.VeliId,
                        principalTable: "conservator",
                        principalColumn: "VeliId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "problems",
                columns: table => new
                {
                    SorunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problems", x => x.SorunId);
                });

            migrationBuilder.CreateTable(
                name: "studentproblems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    SorunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentproblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentproblems_problems_SorunId",
                        column: x => x.SorunId,
                        principalTable: "problems",
                        principalColumn: "SorunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentproblems_students_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "students",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conservator_OdemeId",
                table: "conservator",
                column: "OdemeId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_VeliId",
                table: "payments",
                column: "VeliId");

            migrationBuilder.CreateIndex(
                name: "IX_studentproblems_OgrenciId",
                table: "studentproblems",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_studentproblems_SorunId",
                table: "studentproblems",
                column: "SorunId");

            migrationBuilder.AddForeignKey(
                name: "FK_conservator_payments_OdemeId",
                table: "conservator",
                column: "OdemeId",
                principalTable: "payments",
                principalColumn: "OdemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_beds_YatakId",
                table: "rooms",
                column: "YatakId",
                principalTable: "beds",
                principalColumn: "YatakId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_conservator_VeliId",
                table: "students",
                column: "VeliId",
                principalTable: "conservator",
                principalColumn: "VeliId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_BolumId",
                table: "students",
                column: "BolumId",
                principalTable: "departments",
                principalColumn: "BolumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_rooms_OdaId",
                table: "students",
                column: "OdaId",
                principalTable: "rooms",
                principalColumn: "OdaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_OkulId",
                table: "students",
                column: "OkulId",
                principalTable: "schools",
                principalColumn: "OkulId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conservator_payments_OdemeId",
                table: "conservator");

            migrationBuilder.DropForeignKey(
                name: "FK_rooms_beds_YatakId",
                table: "rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_students_conservator_VeliId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_BolumId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_rooms_OdaId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_OkulId",
                table: "students");

            migrationBuilder.DropTable(
                name: "announcements");

            migrationBuilder.DropTable(
                name: "foods");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "studentproblems");

            migrationBuilder.DropTable(
                name: "problems");

            migrationBuilder.DropIndex(
                name: "IX_conservator_OdemeId",
                table: "conservator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rooms",
                table: "rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_beds",
                table: "beds");

            migrationBuilder.DropColumn(
                name: "OdemeId",
                table: "conservator");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Ogrenci");

            migrationBuilder.RenameTable(
                name: "rooms",
                newName: "Oda");

            migrationBuilder.RenameTable(
                name: "beds",
                newName: "Yatak");

            migrationBuilder.RenameIndex(
                name: "IX_students_VeliId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_VeliId");

            migrationBuilder.RenameIndex(
                name: "IX_students_OkulId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_OkulId");

            migrationBuilder.RenameIndex(
                name: "IX_students_OdaId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_OdaId");

            migrationBuilder.RenameIndex(
                name: "IX_students_BolumId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_BolumId");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_YatakId",
                table: "Oda",
                newName: "IX_Oda_YatakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci",
                column: "OgrenciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oda",
                table: "Oda",
                column: "OdaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yatak",
                table: "Yatak",
                column: "YatakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oda_Yatak_YatakId",
                table: "Oda",
                column: "YatakId",
                principalTable: "Yatak",
                principalColumn: "YatakId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_departments_BolumId",
                table: "Ogrenci",
                column: "BolumId",
                principalTable: "departments",
                principalColumn: "BolumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_schools_OkulId",
                table: "Ogrenci",
                column: "OkulId",
                principalTable: "schools",
                principalColumn: "OkulId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
