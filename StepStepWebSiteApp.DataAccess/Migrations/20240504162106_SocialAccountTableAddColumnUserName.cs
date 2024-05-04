using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepStepWebSiteApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SocialAccountTableAddColumnUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SocialAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SocialAccounts");
        }
    }
}
