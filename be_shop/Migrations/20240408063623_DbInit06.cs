using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace be_shop.Migrations
{
    public partial class DbInit06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "province_code",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "total_price",
                table: "customer");

            migrationBuilder.RenameColumn(
                name: "count_purchases",
                table: "customer",
                newName: "point");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "customer",
                newName: "signature");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "affliate",
                table: "customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customer_affliate",
                table: "customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "customer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "affliate",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "customer_affliate",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "password",
                table: "customer");

            migrationBuilder.RenameColumn(
                name: "signature",
                table: "customer",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "point",
                table: "customer",
                newName: "count_purchases");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "province_code",
                table: "customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "total_price",
                table: "customer",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
