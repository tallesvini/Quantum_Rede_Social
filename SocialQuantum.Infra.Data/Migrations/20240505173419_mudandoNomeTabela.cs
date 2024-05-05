using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class mudandoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FOLLOWERS");

            migrationBuilder.CreateTable(
                name: "FOLLOWS",
                columns: table => new
                {
                    FOLLOWERS_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    USER_FOLLOWER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USER_FOLLOWING_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FOLLOWER_CREATE_DATE = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLLOWS", x => x.FOLLOWERS_ID);
                    table.ForeignKey(
                        name: "FK_FOLLOWS_USERS_USER_FOLLOWER_ID",
                        column: x => x.USER_FOLLOWER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FOLLOWS_USERS_USER_FOLLOWING_ID",
                        column: x => x.USER_FOLLOWING_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWS_USER_FOLLOWER_ID",
                table: "FOLLOWS",
                column: "USER_FOLLOWER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWS_USER_FOLLOWING_ID",
                table: "FOLLOWS",
                column: "USER_FOLLOWING_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FOLLOWS");

            migrationBuilder.CreateTable(
                name: "FOLLOWERS",
                columns: table => new
                {
                    FOLLOWERS_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    USER_FOLLOWER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USER_FOLLOWING_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FOLLOWER_CREATE_DATE = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLLOWERS", x => x.FOLLOWERS_ID);
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_USER_FOLLOWER_ID",
                        column: x => x.USER_FOLLOWER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FOLLOWERS_USERS_USER_FOLLOWING_ID",
                        column: x => x.USER_FOLLOWING_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWER_ID",
                table: "FOLLOWERS",
                column: "USER_FOLLOWER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FOLLOWERS_USER_FOLLOWING_ID",
                table: "FOLLOWERS",
                column: "USER_FOLLOWING_ID");
        }
    }
}
