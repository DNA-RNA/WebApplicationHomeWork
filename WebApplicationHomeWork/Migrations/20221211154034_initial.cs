using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conservator",
                columns: table => new
                {
                    VeliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeliAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeliSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conservator", x => x.VeliId);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.BolumId);
                });

            migrationBuilder.CreateTable(
                name: "schools",
                columns: table => new
                {
                    OkulId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schools", x => x.OkulId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    OkulId = table.Column<int>(type: "int", nullable: false),
                    OgrenciNo = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sınıf = table.Column<int>(type: "int", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenci_departments_BolumId",
                        column: x => x.BolumId,
                        principalTable: "departments",
                        principalColumn: "BolumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrenci_schools_OkulId",
                        column: x => x.OkulId,
                        principalTable: "schools",
                        principalColumn: "OkulId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_BolumId",
                table: "Ogrenci",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_OkulId",
                table: "Ogrenci",
                column: "OkulId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conservator");

            migrationBuilder.DropTable(
                name: "Ogrenci");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "schools");
        }
    }
}
