using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCollumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_ID",
                table: "FOLLOWERS");

            migrationBuilder.RenameColumn(
                name: "FOLLOWER_ID",
                table: "FOLLOWERS",
                newName: "FOLLOWERS_ID");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "FOLLOWERS",
                newName: "USER_FOLLOWER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_FOLLOWERS_USER_ID",
                table: "FOLLOWERS",
                newName: "IX_FOLLOWERS_USER_FOLLOWER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                column: "USER_FOLLOWER_ID",
                principalTable: "USERS",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS");

            migrationBuilder.RenameColumn(
                name: "FOLLOWERS_ID",
                table: "FOLLOWERS",
                newName: "FOLLOWER_ID");

            migrationBuilder.RenameColumn(
                name: "USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                newName: "USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                newName: "IX_FOLLOWERS_USER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_ID",
                table: "FOLLOWERS",
                column: "USER_ID",
                principalTable: "USERS",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
