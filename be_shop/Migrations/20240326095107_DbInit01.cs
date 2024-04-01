using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace be_shop.Migrations
{
    public partial class DbInit01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sex = table.Column<byte>(type: "tinyint", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_id = table.Column<long>(type: "bigint", nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    size_id = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    total_price = table.Column<double>(type: "float", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "category_news",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_news", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "category_product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    note = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    parent_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<byte>(type: "tinyint", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "image_assets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image_assets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<long>(type: "bigint", nullable: false),
                    title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    short_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ntoe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status_id = table.Column<byte>(type: "tinyint", nullable: false),
                    total_amount = table.Column<double>(type: "float", nullable: false),
                    bank_account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order_detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<long>(type: "bigint", nullable: false),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    size_id = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_detail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    views_count = table.Column<int>(type: "int", nullable: false),
                    stock_quantity = table.Column<int>(type: "int", nullable: false),
                    sold_quantity = table.Column<int>(type: "int", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_file",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_file", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_size",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<long>(type: "bigint", nullable: false),
                    size_id = table.Column<long>(type: "bigint", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_size", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "voucher",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reduction_rate = table.Column<int>(type: "int", nullable: false),
                    reduction_price = table.Column<double>(type: "float", nullable: false),
                    maximum_reduction = table.Column<double>(type: "float", nullable: false),
                    used_quantity = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    status_id = table.Column<byte>(type: "tinyint", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userAdded = table.Column<long>(type: "bigint", nullable: true),
                    userUpdated = table.Column<long>(type: "bigint", nullable: true),
                    dateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voucher", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin_user");

            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropTable(
                name: "category_news");

            migrationBuilder.DropTable(
                name: "category_product");

            migrationBuilder.DropTable(
                name: "image_assets");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "order_detail");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "product_file");

            migrationBuilder.DropTable(
                name: "product_size");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "voucher");
        }
    }
}
