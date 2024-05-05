using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCollumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS");

            migrationBuilder.RenameColumn(
                name: "USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                newName: "USER_FOLLOWING_ID");

            migrationBuilder.RenameIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                newName: "IX_FOLLOWERS_USER_FOLLOWING_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_FOLLOWING_ID",
                table: "FOLLOWERS",
                column: "USER_FOLLOWING_ID",
                principalTable: "USERS",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLLOWERS_USERS_USER_FOLLOWING_ID",
                table: "FOLLOWERS");

            migrationBuilder.RenameColumn(
                name: "USER_FOLLOWING_ID",
                table: "FOLLOWERS",
                newName: "USER_FOLLOWER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWING_ID",
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
    }
}
