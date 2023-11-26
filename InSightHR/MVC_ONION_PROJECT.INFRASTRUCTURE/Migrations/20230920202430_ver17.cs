using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerName",
                table: "AdvancePayments");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "AdvancePayments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "ReturnStatus",
                table: "AdvancePayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayments_EmployeeId",
                table: "AdvancePayments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_Employee_EmployeeId",
                table: "AdvancePayments",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_Employee_EmployeeId",
                table: "AdvancePayments");

            migrationBuilder.DropIndex(
                name: "IX_AdvancePayments_EmployeeId",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AdvancePayments");

            migrationBuilder.DropColumn(
                name: "ReturnStatus",
                table: "AdvancePayments");

            migrationBuilder.AddColumn<string>(
                name: "ManagerName",
                table: "AdvancePayments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
