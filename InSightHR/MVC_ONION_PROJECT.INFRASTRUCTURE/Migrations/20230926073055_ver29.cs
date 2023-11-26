using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class ver29 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reimbursements_Employee_EmployeeID",
                table: "Reimbursements");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Reimbursements",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reimbursements_EmployeeID",
                table: "Reimbursements",
                newName: "IX_Reimbursements_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reimbursements_Employee_EmployeeId",
                table: "Reimbursements",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reimbursements_Employee_EmployeeId",
                table: "Reimbursements");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Reimbursements",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Reimbursements_EmployeeId",
                table: "Reimbursements",
                newName: "IX_Reimbursements_EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reimbursements_Employee_EmployeeID",
                table: "Reimbursements",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
