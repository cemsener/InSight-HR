﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_ONION_PROJECT.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class mighg2509 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<DateTime>(
                name: "SalaryEndDate",
                table: "EmployeeSalary",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryEndDate",
                table: "EmployeeSalary");

        }
    }
}
