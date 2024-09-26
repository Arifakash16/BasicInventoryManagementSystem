using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class renameuserTableToInventoryUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "InventoryUsers");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "InventoryUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryUsers",
                table: "InventoryUsers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryUsers",
                table: "InventoryUsers");

            migrationBuilder.RenameTable(
                name: "InventoryUsers",
                newName: "users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
