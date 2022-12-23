using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class addedusernameforstudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "students");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "students");
        }
    }
}
