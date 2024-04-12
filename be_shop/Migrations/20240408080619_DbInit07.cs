using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace be_shop.Migrations
{
    public partial class DbInit07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "customer",
                newName: "username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "customer",
                newName: "name");
        }
    }
}
