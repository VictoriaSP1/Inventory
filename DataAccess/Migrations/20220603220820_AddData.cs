using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "364794d7-251e-4d98-96d2-c42dca293e9e");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "c345999c-7571-4c76-b5c3-ddc128b1f837");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "705fab8e-e4a8-459c-beea-d4fc36f640d7", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "23cc1cdc-e0f0-4b4d-8d14-f2f47b55d430", "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "23cc1cdc-e0f0-4b4d-8d14-f2f47b55d430");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "705fab8e-e4a8-459c-beea-d4fc36f640d7");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "c345999c-7571-4c76-b5c3-ddc128b1f837", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "364794d7-251e-4d98-96d2-c42dca293e9e", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
