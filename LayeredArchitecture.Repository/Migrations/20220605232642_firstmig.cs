using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LayeredArchitecture.Repository.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buzdolabı", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çamaşır Makinesi", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulaşık Makinesi", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 6, 2, 26, 41, 505, DateTimeKind.Local).AddTicks(5771), "Altus", 7500m, 20, null },
                    { 4, 1, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7762), "Beko", 2500m, 30, null },
                    { 9, 1, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7775), "Altus", 7500m, 20, null },
                    { 2, 2, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7726), "Beko", 5500m, 30, null },
                    { 5, 2, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7766), "Altus", 7500m, 20, null },
                    { 8, 2, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7773), "Beko", 5500m, 30, null },
                    { 3, 3, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7755), "Samsung", 7500m, 20, null },
                    { 6, 3, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7768), "Beko", 3750m, 30, null },
                    { 7, 3, new DateTime(2022, 6, 6, 2, 26, 41, 506, DateTimeKind.Local).AddTicks(7770), "Altus", 7500m, 20, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "Height", "ProductId", "Width" },
                values: new object[,]
                {
                    { 1, "Red", 200, 1, 300 },
                    { 4, "Black", 320, 4, 300 },
                    { 8, "White", 200, 9, 300 },
                    { 2, "Blue", 350, 2, 300 },
                    { 7, "Red", 480, 8, 300 },
                    { 3, "Green", 240, 3, 300 },
                    { 5, "White", 210, 6, 300 },
                    { 6, "Yellow", 740, 7, 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
