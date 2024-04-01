﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using be_shop.Entites;

#nullable disable

namespace be_shop.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("be_shop.Entites.Admin_User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("pass_code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<byte>("sex")
                        .HasColumnType("tinyint");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("admin_user");
                });

            modelBuilder.Entity("be_shop.Entites.Cart", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<long>("cart_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<long>("size_id")
                        .HasColumnType("bigint");

                    b.Property<double>("total_price")
                        .HasColumnType("float");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.Property<long>("user_id")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("cart");
                });

            modelBuilder.Entity("be_shop.Entites.Category_News", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("category_news");
                });

            modelBuilder.Entity("be_shop.Entites.Category_Product", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.Property<long>("parent_id")
                        .HasColumnType("bigint");

                    b.Property<byte>("status_id")
                        .HasColumnType("tinyint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("category_product");
                });

            modelBuilder.Entity("be_shop.Entites.Customer", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("count_purchases")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("province_code")
                        .HasColumnType("int");

                    b.Property<double>("total_price")
                        .HasColumnType("float");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("be_shop.Entites.Image_Assets", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("image_assets");
                });

            modelBuilder.Entity("be_shop.Entites.News", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("category_id")
                        .HasColumnType("bigint");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("short_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("news");
                });

            modelBuilder.Entity("be_shop.Entites.Order", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("bank_account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("ntoe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("status_id")
                        .HasColumnType("tinyint");

                    b.Property<double>("total_amount")
                        .HasColumnType("float");

                    b.Property<string>("transaction_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("order");
                });

            modelBuilder.Entity("be_shop.Entites.Order_detail", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<long>("order_id")
                        .HasColumnType("bigint");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<long>("size_id")
                        .HasColumnType("bigint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("order_detail");
                });

            modelBuilder.Entity("be_shop.Entites.Product", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("category_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("sold_quantity")
                        .HasColumnType("int");

                    b.Property<int>("stock_quantity")
                        .HasColumnType("int");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.Property<int>("views_count")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("product");
                });

            modelBuilder.Entity("be_shop.Entites.Product_File", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("product_file");
                });

            modelBuilder.Entity("be_shop.Entites.Product_Size", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<long>("size_id")
                        .HasColumnType("bigint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("product_size");
                });

            modelBuilder.Entity("be_shop.Entites.Size", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("size");
                });

            modelBuilder.Entity("be_shop.Entites.Voucher", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_delete")
                        .HasColumnType("bit");

                    b.Property<double>("maximum_reduction")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("reduction_price")
                        .HasColumnType("float");

                    b.Property<int>("reduction_rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<byte>("status_id")
                        .HasColumnType("tinyint");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<int>("used_quantity")
                        .HasColumnType("int");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long?>("userUpdated")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("voucher");
                });
#pragma warning restore 612, 618
        }
    }
}
