using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class customerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b437f5d-fc6a-40ac-8fe9-d111db8f97d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b88a6bf-d2ab-4665-8506-b831ab38bfca", "1e92ae84-ab9d-4cd9-92c9-0963569de591", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b88a6bf-d2ab-4665-8506-b831ab38bfca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b437f5d-fc6a-40ac-8fe9-d111db8f97d3", "c9e3a9bc-f3b1-4b92-bdd9-07866014c452", "Admin", "ADMIN" });
        }
    }
}
