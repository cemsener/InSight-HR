using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Package_PackageId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_PackageId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Department",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_PackageId",
                table: "Department",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Package_PackageId",
                table: "Department",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id");
        }
    }
}
