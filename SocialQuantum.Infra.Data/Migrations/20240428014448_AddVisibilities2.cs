using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVisibilities2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "VISIBILITY");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "VISIBILITY_CREATE_DATE",
                table: "VISIBILITY",
                type: "TIMESTAMP(7) WITH TIME ZONE",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "NUMBER(1)");

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                table: "VISIBILITY",
                type: "NUMBER(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                table: "VISIBILITY");

            migrationBuilder.AlterColumn<bool>(
                name: "VISIBILITY_CREATE_DATE",
                table: "VISIBILITY",
                type: "NUMBER(1)",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "TIMESTAMP(7) WITH TIME ZONE");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreationDate",
                table: "VISIBILITY",
                type: "TIMESTAMP(7) WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
