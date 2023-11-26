using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class mighg12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaryStatus",
                table: "EmployeeSalary",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryStatus",
                table: "EmployeeSalary");
        }
    }
}
