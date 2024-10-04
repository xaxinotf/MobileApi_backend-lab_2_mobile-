using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobileApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Distance", "Name", "Population" },
                values: new object[,]
                {
                    { 1, 0.0, "Київ", 2884000 },
                    { 2, 540.70000000000005, "Львів", 717273 },
                    { 3, 475.39999999999998, "Одеса", 1010537 },
                    { 4, 489.0, "Харків", 1421125 },
                    { 5, 650.5, "Дніпро", 1002000 },
                    { 6, 550.20000000000005, "Запоріжжя", 729000 },
                    { 7, 265.30000000000001, "Вінниця", 372700 },
                    { 8, 140.59999999999999, "Чернігів", 285234 },
                    { 9, 350.80000000000001, "Полтава", 300400 },
                    { 10, 620.5, "Івано-Франківськ", 237700 }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "oleksii.symonenko@gmail.com", "Oleksii Symonenko" },
                    { 2, "kateryna.ivanova@ukr.net", "Kateryna Ivanova" },
                    { 3, "dmytro.lysenko@gmail.com", "Dmytro Lysenko" },
                    { 4, "olena.hladka@gmail.com", "Olena Hladka" },
                    { 5, "pavlo.shevchuk@ukr.net", "Pavlo Shevchuk" },
                    { 6, "anatolii.troian@gmail.com", "Anatolii Troian" },
                    { 7, "yana.dubovyk@gmail.com", "Yana Dubovyk" },
                    { 8, "serhii.naumenko@ukr.net", "Serhii Naumenko" },
                    { 9, "oksana.mykhailenko@gmail.com", "Oksana Mykhailenko" },
                    { 10, "andrii.voronenko@ukr.net", "Andrii Voronenko" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
