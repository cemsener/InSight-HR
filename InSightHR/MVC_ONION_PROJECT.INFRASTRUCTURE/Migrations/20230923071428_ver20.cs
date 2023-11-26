using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OrganizationPhone",
                table: "Organization",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEnd",
                table: "Organization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractStart",
                table: "Organization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeOfNumber",
                table: "Organization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationEmail",
                table: "Organization",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Organization",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxNumber",
                table: "Organization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "logo",
                table: "Organization",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    NumberOfUser = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_Package_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organization_PackageId",
                table: "Organization",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PackageId",
                table: "Package",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organization_Package_PackageId",
                table: "Organization",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organization_Package_PackageId",
                table: "Organization");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Organization_PackageId",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "ContractEnd",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "ContractStart",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "EmployeeOfNumber",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "OrganizationEmail",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "TaxNumber",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "logo",
                table: "Organization");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationPhone",
                table: "Organization",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
