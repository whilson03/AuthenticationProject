using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationProject.Data.Migrations
{
    public partial class rolesseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de02f17f-2b74-4e05-93a9-adb8d0dc5252", "fc95eed8-aaef-4e7d-8af2-85316a4cdbad", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89c234d9-8406-4b24-be8c-af9951ce3113", "6e76d6d1-07ad-497a-ab10-84440f5a1014", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89c234d9-8406-4b24-be8c-af9951ce3113");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de02f17f-2b74-4e05-93a9-adb8d0dc5252");
        }
    }
}
