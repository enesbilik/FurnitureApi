using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1000, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(4480), false, "Sofa" },
                    { 1002, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(4510), false, "Chair" },
                    { 1003, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(4510), false, "Table" },
                    { 1004, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(4510), false, "Bed" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, 1000, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(4990), "Lorem ipsum Dolor sit amet", false, 19.399999999999999, 4.5, "Comfortable Sofa" },
                    { 2, 1002, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(5000), "Lorem ipsum Dolor sit amet", false, 29.989999999999998, 4.0, "Leather Chair" },
                    { 3, 1003, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(5000), "Lorem ipsum Dolor sit amet", false, 39.990000000000002, 4.2000000000000002, "Modern Table" },
                    { 4, 1004, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(5000), "Lorem ipsum Dolor sit amet", false, 99.989999999999995, 4.7999999999999998, "King-sized Bed" },
                    { 5, 1000, new DateTime(2023, 11, 12, 21, 2, 29, 419, DateTimeKind.Local).AddTicks(5000), "Lorem ipsum Dolor sit amet", false, 59.399999999999999, 3.5, "Sofa Later" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
