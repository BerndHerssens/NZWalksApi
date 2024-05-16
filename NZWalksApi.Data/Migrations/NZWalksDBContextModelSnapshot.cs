﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalksApi.Data;

#nullable disable

namespace NZWalksApi.Data.Migrations
{
    [DbContext(typeof(NZWalksDBContext))]
    partial class NZWalksDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalksApi.Data.Entities.RegionEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BeautyGrade")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BeautyGrade = 4,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(684),
                            Description = "They make Path of Exile here...",
                            Name = "Auckland",
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(735)
                        },
                        new
                        {
                            ID = 2,
                            BeautyGrade = 2,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(740),
                            Description = "Best day hike for active families 13km (8 miles), 4-5 hours, easy to moderate.",
                            Name = "Kosciuszko",
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(742)
                        });
                });

            modelBuilder.Entity("NZWalksApi.Data.Entities.WalkEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("RegionID");

                    b.ToTable("Walks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(821),
                            Description = "This is a beautiful walk by the ocean",
                            LengthInKm = 20.5,
                            Name = "Great ocean walk",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(823)
                        },
                        new
                        {
                            ID = 2,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(826),
                            Description = "This is a beautiful walk in the forrest",
                            LengthInKm = 10.5,
                            Name = "Great forrest walk",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(827)
                        },
                        new
                        {
                            ID = 3,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(830),
                            Description = "This is a beautiful walk by a lake",
                            LengthInKm = 15.5,
                            Name = "Great lake walk",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(831)
                        },
                        new
                        {
                            ID = 4,
                            Created = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(833),
                            Description = "This is a beautiful walk in the mountains",
                            LengthInKm = 18.5,
                            Name = "Great mountain walk",
                            RegionID = 2,
                            Updated = new DateTime(2024, 5, 16, 9, 16, 18, 359, DateTimeKind.Local).AddTicks(834)
                        });
                });

            modelBuilder.Entity("NZWalksApi.Data.Entities.WalkEntity", b =>
                {
                    b.HasOne("NZWalksApi.Data.Entities.RegionEntity", "Region")
                        .WithMany("Walks")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("NZWalksApi.Data.Entities.RegionEntity", b =>
                {
                    b.Navigation("Walks");
                });
#pragma warning restore 612, 618
        }
    }
}
