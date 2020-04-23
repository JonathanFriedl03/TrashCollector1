using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class newEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ed7daff-45ac-40c9-be93-bb82d857c3c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad11c31a-4628-47ec-87ba-baf5ff3209f6");

            migrationBuilder.DropColumn(
                name: "DayToPickUp",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "PickUpDay",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PickUpDay",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b5fcfcc-81fa-4086-afcd-342c892eea92", "13862bb3-c321-4f44-b0c1-0ecda92973e1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a808dd89-77af-4aca-812e-af1eeab34da7", "6a83e370-bacc-429e-84da-74efb92cefbb", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b5fcfcc-81fa-4086-afcd-342c892eea92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a808dd89-77af-4aca-812e-af1eeab34da7");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "DayToPickUp",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ed7daff-45ac-40c9-be93-bb82d857c3c9", "eae6fbc9-45a2-413b-be93-9f588e46a73a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad11c31a-4628-47ec-87ba-baf5ff3209f6", "622ba24c-9062-400e-9466-2f7d9cd2d5dc", "Employee", "EMPLOYEE" });
        }
    }
}
