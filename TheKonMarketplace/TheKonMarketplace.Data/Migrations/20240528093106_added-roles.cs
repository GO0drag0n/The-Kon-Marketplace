using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheKonMarketplace.Data.Migrations
{
    public partial class addedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e9b95d-3b67-46e5-bdd5-8f850ed416e6", "9193f927-8271-4a45-b571-7c18f805e18f", "User", "USER" },
                    { "484d5e1f-080d-4bc6-a5be-fbab112098b2", "3820dc24-00ef-4e80-b8ac-9a1ad0894149", "Seller", "SELLER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59e666ed-9115-41c6-b9d7-82be051abe50", "AQAAAAEAACcQAAAAEAZ8UDYS9S8kLmth+uuAxNuy5HdjCj8/SmTo5v+F8y2xwsHygMUwkpkDlq0osunWGA==", "73601e8f-5b0c-4108-a3d0-17fea6e86ce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6e39491-df4c-45af-90cd-8c81ce4fd497", "AQAAAAEAACcQAAAAEOiUlYhld9+EHHWetdGleY/o++7aixaIREyMUV+4JJJ2ByO18gCJQuljjd186aEvsA==", "44a97151-3159-4b3c-8af7-2e6088945b31" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e9b95d-3b67-46e5-bdd5-8f850ed416e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "484d5e1f-080d-4bc6-a5be-fbab112098b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b8f8a0-b920-487b-975e-428fda6002fd", "AQAAAAEAACcQAAAAEL8PC9YpanhVdIr27brcsNZnsjdpNRigpb/Vmnvw5+0iBH0+m5MxwWQcrPROSRGFTg==", "5f77ddc0-3016-4ec9-b629-0cd8e09754bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4954a92f-95a1-4f5d-916e-887b162eef1a", "AQAAAAEAACcQAAAAEHH6Vl+xrXGr9Ik8l10FZYzuMadF1KNUX7gTbQsO5kPSji3w/pVOncOXjzMVTqHxOQ==", "390b9133-50b0-40c8-b326-6720a9c2a7e5" });
        }
    }
}
