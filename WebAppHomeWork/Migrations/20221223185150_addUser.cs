using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppHomeWork.Migrations
{
    public partial class addUser : Migration
    {
        private string UserRoleId = Guid.NewGuid().ToString();
        private string AdminRoleId = Guid.NewGuid().ToString();
        private string ManagerRoleId = Guid.NewGuid().ToString();

        private string User3Id = Guid.NewGuid().ToString();
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedUser(migrationBuilder);
            SeedUserRoles(migrationBuilder);
        }
        private void SeedUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @$"INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], 
[Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], 
[PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
VALUES 
(N'{User3Id}', N'Test 4', N'Lasttest', N'test4@test.com', N'TEST4@TEST.COM', 
N'test2@test.ca', N'TEST2@TEST.CA', 0, 
N'AQAAAAEAACcQAAAAECH65rHGR9lRq+76xSvkrgzItfgAPmTewMHqDqt5vh6qI0QNHD3wKQlULTQNuFXaIA==', 
N'YUPAFWNGZI2UC5FOITC7PX5J7XZTAZAA', N'8e150555-a20d-4610-93ff-49c5af44f749', NULL, 0, 0, NULL, 1, 0)");


        }
        private void SeedUserRoles(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"
        INSERT INTO [dbo].[AspNetUserRoles]
           ([UserId]
           ,[RoleId])
        VALUES
           ('{User3Id}', '{AdminRoleId}');");



        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
