using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepStepWebSiteApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FeatureTableNewColumnBackGroundImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackGroundImageUrl",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackGroundImageUrl",
                table: "Features");
        }
    }
}
