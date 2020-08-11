﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(BakeSaleDbContext))]
    [Migration("20200811191221_AddedSimpleVendorData")]
    partial class AddedSimpleVendorData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BakeSale.Data.Core.CurrencyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BanknotesAndCoinsInStringFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrencyData");
                });

            modelBuilder.Entity("BakeSale.Data.Core.MoneyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<string>("CurrencyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("MoneyData");
                });

            modelBuilder.Entity("BakeSale.Data.Domain.ProductData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("ProductData");
                });

            modelBuilder.Entity("BakeSale.Data.Domain.VendorData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountBalanceString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIdsAndQuantities")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VendorData");
                });

            modelBuilder.Entity("BakeSale.Data.Core.MoneyData", b =>
                {
                    b.HasOne("BakeSale.Data.Core.CurrencyData", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");
                });

            modelBuilder.Entity("BakeSale.Data.Domain.ProductData", b =>
                {
                    b.HasOne("BakeSale.Data.Core.MoneyData", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");
                });
#pragma warning restore 612, 618
        }
    }
}
