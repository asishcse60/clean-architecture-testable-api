using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRLeaveManagement.Persistence.Migrations
{
    public partial class SeedingLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DefaultDays", "LastModifiedBy", "LastModifiedDateTime", "Name" },
                values: new object[] { 1, "Asish", new DateTime(2022, 4, 23, 23, 33, 0, 177, DateTimeKind.Local).AddTicks(959), 10, "Asish", new DateTime(2022, 4, 23, 23, 33, 0, 177, DateTimeKind.Local).AddTicks(967), "Vacation" });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DefaultDays", "LastModifiedBy", "LastModifiedDateTime", "Name" },
                values: new object[] { 2, "Asish", new DateTime(2022, 4, 23, 23, 33, 0, 177, DateTimeKind.Local).AddTicks(968), 12, "Asish", new DateTime(2022, 4, 23, 23, 33, 0, 177, DateTimeKind.Local).AddTicks(969), "Sick" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
