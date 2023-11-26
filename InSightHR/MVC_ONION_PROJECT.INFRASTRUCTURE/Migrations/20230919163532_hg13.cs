using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class hg13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeDebit_OrgAssetId",
                table: "EmployeeDebit");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDebit_OrgAssetId",
                table: "EmployeeDebit",
                column: "OrgAssetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeDebit_OrgAssetId",
                table: "EmployeeDebit");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDebit_OrgAssetId",
                table: "EmployeeDebit",
                column: "OrgAssetId",
                unique: true);
        }
    }
}
