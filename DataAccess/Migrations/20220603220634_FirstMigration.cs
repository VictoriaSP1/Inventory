using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseId = table.Column<string>(maxLength: 50, nullable: false),
                    WarehouseName = table.Column<string>(maxLength: 100, nullable: false),
                    WarehouseAddress = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 600, nullable: true),
                    TotalQuatity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    StorageId = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    PartialQuantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    WarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_Storage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Storage_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InOut",
                columns: table => new
                {
                    InputOutputId = table.Column<string>(maxLength: 50, nullable: false),
                    InputOutputDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsInput = table.Column<bool>(nullable: false),
                    StorageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOut", x => x.InputOutputId);
                    table.ForeignKey(
                        name: "FK_InOut_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo del hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "c345999c-7571-4c76-b5c3-ddc128b1f837", "Calle 8 con 23", "Bodega Central" },
                    { "364794d7-251e-4d98-96d2-c42dca293e9e", "Calle norte con occidente", "Bodega Norte" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuatity" },
                values: new object[] { "ASJ-98745", "PRF", "", "Crema para manos marca Tersa", 0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuatity" },
                values: new object[] { "RPT-54658", "SLD", "", "Pastillas para la garganta LESUS", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_InOut_StorageId",
                table: "InOut",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ProductId",
                table: "Storage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_WarehouseId",
                table: "Storage",
                column: "WarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InOut");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
