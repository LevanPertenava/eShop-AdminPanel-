﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.DatabaseRepository.Migrations
{
    public partial class orderchange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserIdId",
                schema: "orders",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                schema: "orders",
                table: "Orders",
                newName: "ApplicationUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserIdId",
                schema: "orders",
                table: "Orders",
                newName: "IX_Orders_ApplicationUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUsersId",
                schema: "orders",
                table: "Orders",
                column: "ApplicationUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUsersId",
                schema: "orders",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ApplicationUsersId",
                schema: "orders",
                table: "Orders",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ApplicationUsersId",
                schema: "orders",
                table: "Orders",
                newName: "IX_Orders_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserIdId",
                schema: "orders",
                table: "Orders",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
