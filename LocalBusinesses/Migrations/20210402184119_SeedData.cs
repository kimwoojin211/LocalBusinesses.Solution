using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinesses.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Category", "HoursClose", "HoursOpen", "Name", "OwnedBy", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "1 Mom St.", "Restaurant", "23:59", "11:00", "Mom's Spaghetti", "Mom Mom", "180000081" },
                    { 2, "2 Mom St.", "Shop", "22:00", "08:00", "Momma's", "Moms", "180000082" },
                    { 3, "3 Mom St.", "Restaurant", "17:00", "08:00", "Mom's", "Mommy", "180000083" },
                    { 4, "4 Mom St.", "Shop", "20:00", "06:00", "Mother", "Mother Dearest", "180000084" },
                    { 5, "5 Mom St.", "Restaurant", "23:00", "05:00", "Mama's", "Cooking Mama", "180000085" },
                    { 6, "6 Mom St.", "Restaurant", "23:59", "11:00", "Madre", "Mother Español", "180000081" },
                    { 7, "7 Mom St.", "Restaurant", "23:59", "17:00", "Mère", "Les Français", "180000087" },
                    { 8, "8 Mom St.", "Shop", "20:00", "08:00", "For Moms", "Everyone's Mom", "18888888888" },
                    { 9, "9 Mom St.", "Shop", "18:00", "08:00", "Four Moms", "Mom Mom", "180000089" },
                    { 10, "10 Mom St.", "Shop", "23:59", "00:00", "FortMoms", "Flossem McDawsom", "180000810" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10);
        }
    }
}
