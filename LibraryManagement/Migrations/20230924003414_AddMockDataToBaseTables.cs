using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddMockDataToBaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Book",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(750)",
                oldMaxLength: 750,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Biography", "Birthdate", "Name" },
                values: new object[,]
                {
                    { new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748"), null, new DateTime(1965, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Doe" },
                    { new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatatnon proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1920, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank Herbert" },
                    { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1988, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerry Williams" },
                    { new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatatnon proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1995, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeff Willis" },
                    { new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1955, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jennifer Smith" },
                    { new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf"), null, new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Jones" },
                    { new Guid("afc764d1-9a45-4104-a10d-5626b39d770a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1983, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rico Rodriguez" },
                    { new Guid("f6633cae-34f2-48e0-a87a-825747490d0b"), null, new DateTime(1975, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley Louis" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { new Guid("08e95852-2773-4d33-bed7-0383215ab34a"), "Sci-Fi" },
                    { new Guid("0d38c13b-451b-4ffe-9d6f-3949e43604ac"), "Thriller" },
                    { new Guid("290151b2-22b3-401e-a628-89daa9ec3541"), "History" },
                    { new Guid("2f6ca172-ebe6-4111-9dc4-e631c9eae4ce"), "Non-Fiction" },
                    { new Guid("2f8d230d-ce38-46e7-8ac4-6227d98d6d17"), "Science" },
                    { new Guid("49c7e571-ff92-418d-8923-b5f069540749"), "Novel" },
                    { new Guid("607f26b3-33ae-44c3-923a-87925e640946"), "Fantasy" },
                    { new Guid("8a86eddd-6fa0-4ef5-a0d4-1984254ab3ff"), "Horror" },
                    { new Guid("8dd47f81-c0b8-4d69-98c4-792d42d34a22"), "Mystery" },
                    { new Guid("c40c9712-afd0-45e9-ad11-6b492933d633"), "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "ContactInfo", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("327da642-0cdd-4dde-8adc-2cfb1a90795e"), null, null, "Houghton Mifflin" },
                    { new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032"), "contactscholastic@gmail.com", "France", "Scholastic" },
                    { new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2"), "personpublishing@gmail.com", "Germany", "Pearson" },
                    { new Guid("a1a4734d-cb76-41b2-92ef-237ff61c660a"), "penguinpublishing@gmail.com", "USA", "Penguin Random House" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("afc764d1-9a45-4104-a10d-5626b39d770a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("f6633cae-34f2-48e0-a87a-825747490d0b"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("08e95852-2773-4d33-bed7-0383215ab34a"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("0d38c13b-451b-4ffe-9d6f-3949e43604ac"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("290151b2-22b3-401e-a628-89daa9ec3541"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("2f6ca172-ebe6-4111-9dc4-e631c9eae4ce"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("2f8d230d-ce38-46e7-8ac4-6227d98d6d17"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("49c7e571-ff92-418d-8923-b5f069540749"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("607f26b3-33ae-44c3-923a-87925e640946"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("8a86eddd-6fa0-4ef5-a0d4-1984254ab3ff"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("8dd47f81-c0b8-4d69-98c4-792d42d34a22"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: new Guid("c40c9712-afd0-45e9-ad11-6b492933d633"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("327da642-0cdd-4dde-8adc-2cfb1a90795e"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("a1a4734d-cb76-41b2-92ef-237ff61c660a"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Book",
                type: "nvarchar(750)",
                maxLength: 750,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);
        }
    }
}
