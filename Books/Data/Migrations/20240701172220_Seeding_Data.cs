using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,] {
                    {1, "F. Scott Fitzgerald" },
                    {2, "Harper Lee"},
                    {3, "Jane Austen"},
                    {4, "Miguel de Cervantes"},
                    {5, "J. R. R. Tolkien"},
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "PublisherName" },
                values: new object[,] {
                    {1, "Profil" },
                    {2, "Penguin Random House"},
                    {3, "HarperCollins"},
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
