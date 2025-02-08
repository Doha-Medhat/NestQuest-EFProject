﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NestQuest.Model;

#nullable disable

namespace NestQuest.Migrations
{
    [DbContext(typeof(RealEstateContext))]
    [Migration("20250207223935_updatedata_v4")]
    partial class updatedata_v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NestQuest.Model.Properties", b =>
                {
                    b.Property<int>("propId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("propId"));

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ownerId")
                        .HasColumnType("int");

                    b.HasKey("propId");

                    b.HasIndex("ownerId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("NestQuest.Model.PropertyImage", b =>
                {
                    b.Property<int>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImgId"));

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropId")
                        .HasColumnType("int");

                    b.HasKey("ImgId");

                    b.HasIndex("PropId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("NestQuest.Model.Transaction", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("PropertyId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<DateTime?>("TransDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("NestQuest.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NestQuest.Model.Properties", b =>
                {
                    b.HasOne("NestQuest.Model.User", "Owner")
                        .WithMany("properties")
                        .HasForeignKey("ownerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("NestQuest.Model.PropertyImage", b =>
                {
                    b.HasOne("NestQuest.Model.Properties", "property")
                        .WithMany("ProperityImages")
                        .HasForeignKey("PropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("property");
                });

            modelBuilder.Entity("NestQuest.Model.Transaction", b =>
                {
                    b.HasOne("NestQuest.Model.User", "Client")
                        .WithMany("Transactions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NestQuest.Model.Properties", "Property")
                        .WithMany("transactions")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("NestQuest.Model.Properties", b =>
                {
                    b.Navigation("ProperityImages");

                    b.Navigation("transactions");
                });

            modelBuilder.Entity("NestQuest.Model.User", b =>
                {
                    b.Navigation("Transactions");

                    b.Navigation("properties");
                });
#pragma warning restore 612, 618
        }
    }
}
