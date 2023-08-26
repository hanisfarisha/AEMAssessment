﻿// <auto-generated />
using System;
using AEMTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AEMTest.Migrations
{
    [DbContext(typeof(PlatformWellContext))]
    [Migration("20230823095824_addedwell")]
    partial class addedwell
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AEMTest.Models.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformId"));

                    b.Property<DateTimeOffset>("CreatedDatetime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PlatformCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlatformId1")
                        .HasColumnType("int");

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedDatetime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("PlatformId");

                    b.HasIndex("PlatformId1");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("AEMTest.Models.Well", b =>
                {
                    b.Property<int>("WellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WellId"));

                    b.Property<DateTimeOffset>("CreatedDatetime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedDatetime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("WellString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WellId");

                    b.HasIndex("PlatformId");

                    b.ToTable("Wells");
                });

            modelBuilder.Entity("AEMTest.Models.Platform", b =>
                {
                    b.HasOne("AEMTest.Models.Platform", null)
                        .WithMany("Platforms")
                        .HasForeignKey("PlatformId1");
                });

            modelBuilder.Entity("AEMTest.Models.Well", b =>
                {
                    b.HasOne("AEMTest.Models.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("AEMTest.Models.Platform", b =>
                {
                    b.Navigation("Platforms");
                });
#pragma warning restore 612, 618
        }
    }
}