﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalStock.Persistance;

#nullable disable

namespace MinimalStock.Persistance.Migrations
{
    [DbContext(typeof(MinimalStockContext))]
    partial class MinimalStockContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("MinimalStock.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Oid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MinimalStock.Domain.Entities.CategoryConfiguration", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryOid")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FieldOid")
                        .HasColumnType("TEXT");

                    b.HasKey("Oid");

                    b.HasIndex("CategoryOid");

                    b.HasIndex("FieldOid");

                    b.ToTable("CategoriesConfiguration");
                });

            modelBuilder.Entity("MinimalStock.Domain.Entities.Field", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Oid");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("MinimalStock.Domain.Entities.CategoryConfiguration", b =>
                {
                    b.HasOne("MinimalStock.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryOid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinimalStock.Domain.Entities.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldOid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Field");
                });
#pragma warning restore 612, 618
        }
    }
}
