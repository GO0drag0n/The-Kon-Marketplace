using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheKonMarketplace.Data.Migrations
{
    public partial class OfferAndSellerRelationFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e9b95d-3b67-46e5-bdd5-8f850ed416e6",
                column: "ConcurrencyStamp",
                value: "f2ba1883-df49-4015-a5e6-03fbf7ed81b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "484d5e1f-080d-4bc6-a5be-fbab112098b2",
                column: "ConcurrencyStamp",
                value: "896c9b08-e2de-4877-9c57-c56e9c29bfe5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e342ec-c806-4d66-a191-32e933c7364b", "AQAAAAEAACcQAAAAEONLKuCpQ5u8lCwwE6W7ZJJFWqppjmOBh0Hez/QmS5VtiaKLxgeDGaGFwFFKy0AE5w==", "0cf77283-a4e6-47a3-910d-4a352fe8d48c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aba044e2-6e36-409a-8668-1e2154890bd8", "AQAAAAEAACcQAAAAEOnkrAYiSpQ5JkQaXOIX9V9FNyBXCWJ404IjRmYFSFVieuz0eMSWqdl4s5T7NH099g==", "81764438-a142-4aa5-b61e-f7091a656501" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e9b95d-3b67-46e5-bdd5-8f850ed416e6",
                column: "ConcurrencyStamp",
                value: "9193f927-8271-4a45-b571-7c18f805e18f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "484d5e1f-080d-4bc6-a5be-fbab112098b2",
                column: "ConcurrencyStamp",
                value: "3820dc24-00ef-4e80-b8ac-9a1ad0894149");

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

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "American Quarter Horse" },
                    { 2, "Arabian" },
                    { 3, "Thoroughbred" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "BreedId", "CreatedAt", "Description", "ImageUrl", "Location", "Price", "Title", "UserId" },
                values: new object[] { 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5 year old Horse at its prime", "https://horseyhooves.com/wp-content/uploads/2020/10/American-Quarter-Horse-1.jpg", "North London, UK (near the border)", 2100.00m, "Thoroughbred - Hasan", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "BreedId", "CreatedAt", "Description", "ImageUrl", "Location", "Price", "Title", "UserId" },
                values: new object[] { 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 year for sudjuk", "https://horseyhooves.com/wp-content/uploads/2022/03/Beautiful-black-Friesian-horse-standing-in-a-grass-paddock.jpg.webp", "Albania", 1500.00m, "Thoroughbred - Anton", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "BreedId", "CreatedAt", "Description", "ImageUrl", "Location", "Price", "Title", "UserId" },
                values: new object[] { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very fast horse", "https://horseyhooves.com/wp-content/uploads/2020/10/Arabian-horse-breed-1.jpg", "Albania, Kosovo", 2100.00m, "Arabian - Muhamed", "dea12856-c198-4129-b3f3-b893d8395082" });
        }
    }
}
