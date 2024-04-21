using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialQuantum.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class novaTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "USER_CREATING_DATE",
                table: "USERS",
                type: "TIMESTAMP(7) WITH TIME ZONE",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "TIMESTAMP(7) WITH TIME ZONE",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "USER_CREATING_DATE",
                table: "USERS",
                type: "TIMESTAMP(7) WITH TIME ZONE",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "TIMESTAMP(7) WITH TIME ZONE");
        }
    }
}
