using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Package_Package_PackageId",
                table: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Package_PackageId",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Package");

            migrationBuilder.AddColumn<double>(
                name: "PackageDurationMonth",
                table: "Package",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Package_PackageId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_PackageId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "PackageDurationMonth",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Department");

            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Package",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Package_PackageId",
                table: "Package",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Package_PackageId",
                table: "Package",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id");
        }
    }
}
