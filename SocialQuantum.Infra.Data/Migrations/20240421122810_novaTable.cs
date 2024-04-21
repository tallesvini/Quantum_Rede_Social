using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class novaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STATUS_ACCOUNTS",
                columns: table => new
                {
                    STATUS_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NAME = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    STATUS_CREATING_DATE = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS_ACCOUNTS", x => x.STATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    USERNAME = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    PASSWORD = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    NAME = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    USER_PHOTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    BIOGRAPHY = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LOCATION = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    STATUS_ACCOUNT_ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    USER_CREATING_DATE = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USER_ID);
                    table.ForeignKey(
                        name: "FK_USERS_STATUS_ACCOUNTS_STATUS_ACCOUNT_ID",
                        column: x => x.STATUS_ACCOUNT_ID,
                        principalTable: "STATUS_ACCOUNTS",
                        principalColumn: "STATUS_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_USERS_STATUS_ACCOUNT_ID",
                table: "USERS",
                column: "STATUS_ACCOUNT_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "STATUS_ACCOUNTS");
        }
    }
}
