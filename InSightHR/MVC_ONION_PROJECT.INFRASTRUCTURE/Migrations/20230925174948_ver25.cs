using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "TimeOff",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TimeOff_EmployeeId",
                table: "TimeOff",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeOff_Employee_EmployeeId",
                table: "TimeOff",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeOff_Employee_EmployeeId",
                table: "TimeOff");

            migrationBuilder.DropIndex(
                name: "IX_TimeOff_EmployeeId",
                table: "TimeOff");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "TimeOff");
        }
    }
}
