using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicInventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addRegistrationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration");

            migrationBuilder.RenameTable(
                name: "UserRegistration",
                newName: "Registrations");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Registrations",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Registrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Registrations");

            migrationBuilder.RenameTable(
                name: "Registrations",
                newName: "UserRegistration");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "UserRegistration",
                newName: "CreatedAt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRegistration",
                table: "UserRegistration",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InventoryUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryUsers", x => x.Id);
                });
        }
    }
}
