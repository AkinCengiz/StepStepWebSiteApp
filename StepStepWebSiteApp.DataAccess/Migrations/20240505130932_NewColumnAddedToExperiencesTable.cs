using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepStepWebSiteApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewColumnAddedToExperiencesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Experiences");
        }
    }
}
