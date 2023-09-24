using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddMockDataToBookAuthorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5"),
                column: "Availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a499294c-5f69-404f-91b7-c85db7f0a330"),
                column: "Availability",
                value: false);

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") },
                    { new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") },
                    { new Guid("f6633cae-34f2-48e0-a87a-825747490d0b"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") },
                    { new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf"), new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87") },
                    { new Guid("afc764d1-9a45-4104-a10d-5626b39d770a"), new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87") },
                    { new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"), new Guid("3c51ad1c-66e6-4daa-a20e-5c2e72c59802") },
                    { new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"), new Guid("6e8b727f-ecde-4876-916d-e81f12dfa3be") },
                    { new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622"), new Guid("9a2aa24e-19d4-4cbe-bf90-96d625d012e0") },
                    { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5") },
                    { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("a499294c-5f69-404f-91b7-c85db7f0a330") },
                    { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("c79f76c0-8409-4d73-a830-9ece06fb078d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("0a0f05b1-3dd9-4121-9b67-b6c0b609d748"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("44ddfe62-bd28-403f-9825-533f5f90e93f"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("f6633cae-34f2-48e0-a87a-825747490d0b"), new Guid("1be983b8-34cc-41bf-aad0-ff83113c1ca6") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("9aed9ba0-83a6-4b0f-b409-2401ab3e59bf"), new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("afc764d1-9a45-4104-a10d-5626b39d770a"), new Guid("33d274bd-2d9d-472a-b595-4ff4d0bf8c87") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"), new Guid("3c51ad1c-66e6-4daa-a20e-5c2e72c59802") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("0cabada2-7f0c-45bb-8440-c9b3cf8c3972"), new Guid("6e8b727f-ecde-4876-916d-e81f12dfa3be") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("6cf4f63f-0167-4395-81f4-bb5c4969a622"), new Guid("9a2aa24e-19d4-4cbe-bf90-96d625d012e0") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("a499294c-5f69-404f-91b7-c85db7f0a330") });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("4050a949-3f77-43ec-8b3a-ac71bf23b5bd"), new Guid("c79f76c0-8409-4d73-a830-9ece06fb078d") });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a2bb0fd5-5d9b-4b11-a3a3-4948b2f1a5c5"),
                column: "Availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a499294c-5f69-404f-91b7-c85db7f0a330"),
                column: "Availability",
                value: true);
        }
    }
}
