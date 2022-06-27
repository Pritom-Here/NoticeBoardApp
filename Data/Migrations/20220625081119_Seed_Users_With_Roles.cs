using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoticeBoardApp.Data.Migrations
{
    public partial class Seed_Users_With_Roles : Migration
    {
        private string AdminRoleId = Guid.NewGuid().ToString();
        private string RegularUserRoleId = Guid.NewGuid().ToString();

        private string AdminId = Guid.NewGuid().ToString();
        private string RegularUserId = Guid.NewGuid().ToString();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedUsersSql(migrationBuilder);
            SeedRolesSql(migrationBuilder);
            SeedUserRolesSql(migrationBuilder);
        }

        private void SeedUsersSql(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                        $@"INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
                        VALUES ('{AdminId}', N'admin@domain.com', N'ADMIN@DOMAIN.COM', N'admin@domain.com', N'ADMIN@DOMAIN.COM', 1, N'AQAAAAEAACcQAAAAEHwI/wmiAqPA4lp1uSxzM7cT5k794xoi9UY/9I9wD3OOBN2ZOrSXVRi5ycpUBXLgDA==', N'QOBUR5RWK24WOM4TJW4DNZD3X3NEEVRR', N'6d48793a-59d9-4f1b-8f9a-66e1c7d36c40', NULL, 0, 0, NULL, 1, 0)"
                    );
            migrationBuilder.Sql(
                        $@"INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
                        VALUES ('{RegularUserId}', N'user@domain.com', N'USER@DOMAIN.COM', N'user@domain.com', N'USER@DOMAIN.COM', 1, N'AQAAAAEAACcQAAAAEHwI/wmiAqPA4lp1uSxzM7cT5k794xoi9UY/9I9wD3OOBN2ZOrSXVRi5ycpUBXLgDA==', N'QOBUR5RWK24WOM4TJW4DNZD3X3NEEVRR', N'6d48793a-59d9-4f1b-8f9a-66e1c7d36c40', NULL, 0, 0, NULL, 1, 0)"
                    );
        }

        private void SeedRolesSql(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                        $@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) 
                        VALUES ('{AdminRoleId}', N'Administrator', N'ADMINISTRATOR', NULL)"
                    );
            migrationBuilder.Sql(
                        $@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) 
                        VALUES ('{RegularUserRoleId}', N'RegularUser', N'REGULARUSER', NULL)"
                    );
        }

        private void SeedUserRolesSql(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('{AdminId}', '{AdminRoleId}')");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('{RegularUserId}', '{RegularUserRoleId}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
