using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Package",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Package");
        }
    }
}
