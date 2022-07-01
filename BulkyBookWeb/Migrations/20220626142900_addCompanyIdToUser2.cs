using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class addCompanyIdToUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_orderHeaders_OrderId",
                table: "orderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_Products_ProductId",
                table: "orderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_orderHeaders_AspNetUsers_ApplicationUserId",
                table: "orderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderHeaders",
                table: "orderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.RenameTable(
                name: "orderHeaders",
                newName: "OrderHeaders");

            migrationBuilder.RenameTable(
                name: "orderDetail",
                newName: "OrderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_orderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                newName: "IX_OrderHeaders_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_ProductId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetail_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderHeaders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "OrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderHeaders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Products_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                newName: "orderHeaders");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "orderDetail");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "orderHeaders",
                newName: "IX_orderHeaders_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_ProductId",
                table: "orderDetail",
                newName: "IX_orderDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "orderDetail",
                newName: "IX_orderDetail_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderHeaders",
                table: "orderHeaders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_orderHeaders_OrderId",
                table: "orderDetail",
                column: "OrderId",
                principalTable: "orderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_Products_ProductId",
                table: "orderDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderHeaders_AspNetUsers_ApplicationUserId",
                table: "orderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
