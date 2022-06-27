using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoticeBoardApp.Data.Migrations
{
    public partial class NewEntity_NoticeViewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NoticeViewers",
                columns: table => new
                {
                    NoticeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeViewers", x => new { x.NoticeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_NoticeViewers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NoticeViewers_Notices_NoticeId",
                        column: x => x.NoticeId,
                        principalTable: "Notices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NoticeViewers_UserId",
                table: "NoticeViewers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoticeViewers");
        }
    }
}
