using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobileApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContactsWithKnu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 11, "ihor.zubov@knu.ua", "Ihor Zubov" },
                    { 12, "mariia.pidgorna@knu.ua", "Mariia Pidgorna" },
                    { 13, "mykola.stepanov@knu.ua", "Mykola Stepanov" },
                    { 14, "svitlana.prokopenko@knu.ua", "Svitlana Prokopenko" },
                    { 15, "vasyl.vorobets@knu.ua", "Vasyl Vorobets" },
                    { 16, "olha.poliak@knu.ua", "Olha Poliak" },
                    { 17, "petro.yarema@knu.ua", "Petro Yarema" },
                    { 18, "inna.hrytsenko@knu.ua", "Inna Hrytsenko" },
                    { 19, "natalia.shevchenko@knu.ua", "Natalia Shevchenko" },
                    { 20, "roman.holovko@knu.ua", "Roman Holovko" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
