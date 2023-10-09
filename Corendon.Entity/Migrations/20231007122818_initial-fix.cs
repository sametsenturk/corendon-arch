using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corendon.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initialfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_Id",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnnouncementVotes_Id",
                table: "UserAnnouncementVotes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnnouncementComments_Id",
                table: "UserAnnouncementComments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartments_Id",
                table: "CompanyDepartments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Id",
                table: "Companies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_Id",
                table: "Announcements",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserNotifications_Id",
                table: "UserNotifications");

            migrationBuilder.DropIndex(
                name: "IX_UserAnnouncementVotes_Id",
                table: "UserAnnouncementVotes");

            migrationBuilder.DropIndex(
                name: "IX_UserAnnouncementComments_Id",
                table: "UserAnnouncementComments");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDepartments_Id",
                table: "CompanyDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Id",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_Id",
                table: "Announcements");
        }
    }
}
