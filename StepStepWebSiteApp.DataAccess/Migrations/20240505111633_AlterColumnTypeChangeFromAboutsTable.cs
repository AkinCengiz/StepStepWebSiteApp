using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepStepWebSiteApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumnTypeChangeFromAboutsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Abouts");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthTime",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthTime",
                table: "Abouts");

            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "Abouts",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
