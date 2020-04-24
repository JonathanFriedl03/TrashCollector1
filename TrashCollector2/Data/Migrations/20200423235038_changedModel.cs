using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class changedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b5fcfcc-81fa-4086-afcd-342c892eea92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a808dd89-77af-4aca-812e-af1eeab34da7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94246762-4674-4ac9-9930-5223361e6bd1", "a0873ad2-2fec-46f7-a645-0722b01c0137", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf3be44b-1a03-4d07-94fc-d1a421bd41e7", "82f1d900-7aa2-44a9-9cad-219d1c664aec", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94246762-4674-4ac9-9930-5223361e6bd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf3be44b-1a03-4d07-94fc-d1a421bd41e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b5fcfcc-81fa-4086-afcd-342c892eea92", "13862bb3-c321-4f44-b0c1-0ecda92973e1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a808dd89-77af-4aca-812e-af1eeab34da7", "6a83e370-bacc-429e-84da-74efb92cefbb", "Employee", "EMPLOYEE" });
        }
    }
}
