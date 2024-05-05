using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class incluindoFollowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FOLLOWERS",
                columns: table => new
                {
                    FOLLOWER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    USER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USER_FOLLOWER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FOLLOWER_CREATE_DATE = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLLOWERS", x => x.FOLLOWER_ID);
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_USER_FOLLOWER_ID",
                        column: x => x.USER_FOLLOWER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                column: "USER_FOLLOWER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWERS_USER_ID",
                table: "FOLLOWERS",
                column: "USER_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FOLLOWERS");
        }
    }
}
