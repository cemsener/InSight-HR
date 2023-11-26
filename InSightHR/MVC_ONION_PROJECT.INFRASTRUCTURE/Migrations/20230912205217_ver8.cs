using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photopath",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photopath",
                table: "Employee");
        }
    }
}
