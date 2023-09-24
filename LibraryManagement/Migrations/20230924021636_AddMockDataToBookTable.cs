using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddMockDataToBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Book",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Availability", "BookTitle", "CoverImageURL", "Description", "ISBN", "PageCount", "PublicationDate", "PublisherId" },
                values: new object[,]
                {
                    { new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6"), true, "Sample ScienceHistory", null, null, "9783981372724", 543, new DateTime(2004, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032") },
                    { new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87"), true, "Sample Horror", null, null, "9781677732098", 710, new DateTime(2010, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("327da642-0cdd-4dde-8adc-2cfb1a90795e") },
                    { new Guid("3c51ad1c-66e6-4daa-a20e-5c2e72c59802"), true, "Dune", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "9780233660615", 894, new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2") },
                    { new Guid("6e8b727f-ecde-4876-916d-e81f12dfa3be"), true, "Dune", null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "9780233660615", 894, new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("67d77f42-be53-4e4d-ac30-0b3010cdd7a2") },
                    { new Guid("9a2aa24e-19d4-4cbe-bf90-96d625d012e0"), true, "Sample SciFi", null, null, "9780277097484", 421, new DateTime(1994, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1a4734d-cb76-41b2-92ef-237ff61c660a") },
                    { new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5"), false, "The Catcher in the Rye", null, null, "9787360328388", 510, new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032") },
                    { new Guid("a499294c-5f69-404f-91b7-c85db7f0a330"), true, "The Catcher in the Rye", null, null, "9787360328388", 510, new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032") },
                    { new Guid("c79f76c0-8409-4d73-a830-9ece06fb078d"), true, "The Catcher in the Rye", null, null, "9787360328388", 510, new DateTime(1980, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bc0b331-5b25-49a4-a86c-c7d2142f0032") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("3c51ad1c-66e6-4daa-a20e-5c2e72c59802"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("6e8b727f-ecde-4876-916d-e81f12dfa3be"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("9a2aa24e-19d4-4cbe-bf90-96d625d012e0"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a499294c-5f69-404f-91b7-c85db7f0a330"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("c79f76c0-8409-4d73-a830-9ece06fb078d"));

            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Book",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
