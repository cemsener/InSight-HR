using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class verhg2509_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationId",
                table: "AssetCategory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategory_OrganizationId",
                table: "AssetCategory",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCategory_Organization_OrganizationId",
                table: "AssetCategory",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCategory_Organization_OrganizationId",
                table: "AssetCategory");

            migrationBuilder.DropIndex(
                name: "IX_AssetCategory_OrganizationId",
                table: "AssetCategory");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "AssetCategory");
        }
    }
}
