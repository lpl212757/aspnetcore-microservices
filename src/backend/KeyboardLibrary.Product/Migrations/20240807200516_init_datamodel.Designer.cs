﻿// <auto-generated />
using System;
using KeyboardLibrary.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeyboardLibrary.Product.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240807200516_init_datamodel")]
    partial class init_datamodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KeyboardLibrary.Product.Domain.Entities.Keycap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Keycaps", (string)null);
                });

            modelBuilder.Entity("KeyboardLibrary.Product.Domain.Entities.KeycapImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("KeycapId")
                        .HasColumnType("int");

                    b.Property<int?>("KeycapId1")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KeycapId");

                    b.HasIndex("KeycapId1");

                    b.ToTable("KeycapImages", (string)null);
                });

            modelBuilder.Entity("KeyboardLibrary.Product.Domain.Entities.KeycapImage", b =>
                {
                    b.HasOne("KeyboardLibrary.Product.Domain.Entities.Keycap", null)
                        .WithMany()
                        .HasForeignKey("KeycapId");

                    b.HasOne("KeyboardLibrary.Product.Domain.Entities.Keycap", "Keycap")
                        .WithMany("Images")
                        .HasForeignKey("KeycapId1");

                    b.Navigation("Keycap");
                });

            modelBuilder.Entity("KeyboardLibrary.Product.Domain.Entities.Keycap", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}