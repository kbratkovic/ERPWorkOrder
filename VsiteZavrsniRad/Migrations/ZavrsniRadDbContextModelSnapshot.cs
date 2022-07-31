﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VsiteZavrsniRad.Database;

#nullable disable

namespace VsiteZavrsniRad.Migrations
{
    [DbContext(typeof(ZavrsniRadDbContext))]
    partial class ZavrsniRadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VsiteZavrsniRad.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClientNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.SparePart_WorkOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SparePartId")
                        .HasColumnType("int");

                    b.Property<int>("WorkOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SparePartId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("SparePart_WorkOrders");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.SparePartModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("PriceWithVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceWithoutVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("quantityTimesPriceWithoutVAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SpareParts");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.WorkOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceItem")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WorkDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("WorkOrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.SparePart_WorkOrderModel", b =>
                {
                    b.HasOne("VsiteZavrsniRad.Models.SparePartModel", "SparePart")
                        .WithMany("SparePart_WorkOrders")
                        .HasForeignKey("SparePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VsiteZavrsniRad.Models.WorkOrderModel", "WorkOrder")
                        .WithMany("SparePart_WorkOrders")
                        .HasForeignKey("WorkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SparePart");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.WorkOrderModel", b =>
                {
                    b.HasOne("VsiteZavrsniRad.Models.ClientModel", "Client")
                        .WithMany("WorkOrders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.ClientModel", b =>
                {
                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.SparePartModel", b =>
                {
                    b.Navigation("SparePart_WorkOrders");
                });

            modelBuilder.Entity("VsiteZavrsniRad.Models.WorkOrderModel", b =>
                {
                    b.Navigation("SparePart_WorkOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
