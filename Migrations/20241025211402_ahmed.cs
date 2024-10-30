using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketDemo.Migrations
{
    public partial class ahmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Order_OrdersId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomesId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Item_ItemsId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Sale_SalesId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "SalesId",
                table: "Orders",
                newName: "SaleId");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "Orders",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "CustomesId",
                table: "Orders",
                newName: "CustomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_SalesId",
                table: "Orders",
                newName: "IX_Orders_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ItemsId",
                table: "Orders",
                newName: "IX_Orders_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomesId",
                table: "Orders",
                newName: "IX_Orders_CustomeId");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "Invoices",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_OrdersId",
                table: "Invoices",
                newName: "IX_Invoices_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomeId",
                table: "Orders",
                column: "CustomeId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemId",
                table: "Orders",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sales_SaleId",
                table: "Orders",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Orders_OrderId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sales_SaleId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Order",
                newName: "SalesId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Order",
                newName: "ItemsId");

            migrationBuilder.RenameColumn(
                name: "CustomeId",
                table: "Order",
                newName: "CustomesId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_SaleId",
                table: "Order",
                newName: "IX_Order_SalesId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ItemId",
                table: "Order",
                newName: "IX_Order_ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomeId",
                table: "Order",
                newName: "IX_Order_CustomesId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Invoice",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_OrderId",
                table: "Invoice",
                newName: "IX_Invoice_OrdersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Order_OrdersId",
                table: "Invoice",
                column: "OrdersId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomesId",
                table: "Order",
                column: "CustomesId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Item_ItemsId",
                table: "Order",
                column: "ItemsId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Sale_SalesId",
                table: "Order",
                column: "SalesId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
