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
                            BeautyGrade = 3,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7331),
                            Description = "Description for region 1",
                            Name = "Region 1",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7368)
                        },
                        new
                        {
                            ID = 2,
                            BeautyGrade = 2,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7375),
                            Description = "Description for region 2",
                            Name = "Region 2",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7376)
                        },
                        new
                        {
                            ID = 3,
                            BeautyGrade = 1,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7378),
                            Description = "Description for region 3",
                            Name = "Region 3",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7379)
                        },
                        new
                        {
                            ID = 4,
                            BeautyGrade = 2,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7382),
                            Description = "Description for region 4",
                            Name = "Region 4",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7383)
                        },
                        new
                        {
                            ID = 5,
                            BeautyGrade = 1,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7386),
                            Description = "Description for region 5",
                            Name = "Region 5",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7387)
                        },
                        new
                        {
                            ID = 6,
                            BeautyGrade = 0,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7392),
                            Description = "Description for region 6",
                            Name = "Region 6",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7393)
                        },
                        new
                        {
                            ID = 7,
                            BeautyGrade = 0,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7395),
                            Description = "Description for region 7",
                            Name = "Region 7",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7396)
                        },
                        new
                        {
                            ID = 8,
                            BeautyGrade = 3,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7401),
                            Description = "Description for region 8",
                            Name = "Region 8",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7402)
                        },
                        new
                        {
                            ID = 9,
                            BeautyGrade = 1,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7404),
                            Description = "Description for region 9",
                            Name = "Region 9",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7405)
                        },
                        new
                        {
                            ID = 10,
                            BeautyGrade = 3,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7409),
                            Description = "Description for region 10",
                            Name = "Region 10",
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7410)
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
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7528),
                            Description = "Description for walk 1",
                            LengthInKm = 17.0,
                            Name = "Walk 1",
                            RegionID = 10,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7530)
                        },
                        new
                        {
                            ID = 2,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7533),
                            Description = "Description for walk 2",
                            LengthInKm = 10.0,
                            Name = "Walk 2",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7534)
                        },
                        new
                        {
                            ID = 3,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7537),
                            Description = "Description for walk 3",
                            LengthInKm = 6.0,
                            Name = "Walk 3",
                            RegionID = 5,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7538)
                        },
                        new
                        {
                            ID = 4,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7540),
                            Description = "Description for walk 4",
                            LengthInKm = 9.0,
                            Name = "Walk 4",
                            RegionID = 10,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7541)
                        },
                        new
                        {
                            ID = 5,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7543),
                            Description = "Description for walk 5",
                            LengthInKm = 14.0,
                            Name = "Walk 5",
                            RegionID = 2,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7544)
                        },
                        new
                        {
                            ID = 6,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7547),
                            Description = "Description for walk 6",
                            LengthInKm = 3.0,
                            Name = "Walk 6",
                            RegionID = 7,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7548)
                        },
                        new
                        {
                            ID = 7,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7550),
                            Description = "Description for walk 7",
                            LengthInKm = 12.0,
                            Name = "Walk 7",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7551)
                        },
                        new
                        {
                            ID = 8,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7554),
                            Description = "Description for walk 8",
                            LengthInKm = 7.0,
                            Name = "Walk 8",
                            RegionID = 2,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7555)
                        },
                        new
                        {
                            ID = 9,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7557),
                            Description = "Description for walk 9",
                            LengthInKm = 6.0,
                            Name = "Walk 9",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7558)
                        },
                        new
                        {
                            ID = 10,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7604),
                            Description = "Description for walk 10",
                            LengthInKm = 4.0,
                            Name = "Walk 10",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7606)
                        },
                        new
                        {
                            ID = 11,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7609),
                            Description = "Description for walk 11",
                            LengthInKm = 9.0,
                            Name = "Walk 11",
                            RegionID = 4,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7610)
                        },
                        new
                        {
                            ID = 12,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7613),
                            Description = "Description for walk 12",
                            LengthInKm = 14.0,
                            Name = "Walk 12",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7614)
                        },
                        new
                        {
                            ID = 13,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7616),
                            Description = "Description for walk 13",
                            LengthInKm = 5.0,
                            Name = "Walk 13",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7617)
                        },
                        new
                        {
                            ID = 14,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7619),
                            Description = "Description for walk 14",
                            LengthInKm = 18.0,
                            Name = "Walk 14",
                            RegionID = 5,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7621)
                        },
                        new
                        {
                            ID = 15,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7623),
                            Description = "Description for walk 15",
                            LengthInKm = 12.0,
                            Name = "Walk 15",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7624)
                        },
                        new
                        {
                            ID = 16,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7626),
                            Description = "Description for walk 16",
                            LengthInKm = 14.0,
                            Name = "Walk 16",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7627)
                        },
                        new
                        {
                            ID = 17,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7629),
                            Description = "Description for walk 17",
                            LengthInKm = 18.0,
                            Name = "Walk 17",
                            RegionID = 4,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7630)
                        },
                        new
                        {
                            ID = 18,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7635),
                            Description = "Description for walk 18",
                            LengthInKm = 10.0,
                            Name = "Walk 18",
                            RegionID = 5,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7636)
                        },
                        new
                        {
                            ID = 19,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7638),
                            Description = "Description for walk 19",
                            LengthInKm = 2.0,
                            Name = "Walk 19",
                            RegionID = 10,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7639)
                        },
                        new
                        {
                            ID = 20,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7642),
                            Description = "Description for walk 20",
                            LengthInKm = 19.0,
                            Name = "Walk 20",
                            RegionID = 9,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7643)
                        },
                        new
                        {
                            ID = 21,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7645),
                            Description = "Description for walk 21",
                            LengthInKm = 3.0,
                            Name = "Walk 21",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7647)
                        },
                        new
                        {
                            ID = 22,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7649),
                            Description = "Description for walk 22",
                            LengthInKm = 6.0,
                            Name = "Walk 22",
                            RegionID = 4,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7650)
                        },
                        new
                        {
                            ID = 23,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7652),
                            Description = "Description for walk 23",
                            LengthInKm = 18.0,
                            Name = "Walk 23",
                            RegionID = 10,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7653)
                        },
                        new
                        {
                            ID = 24,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7655),
                            Description = "Description for walk 24",
                            LengthInKm = 19.0,
                            Name = "Walk 24",
                            RegionID = 5,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7656)
                        },
                        new
                        {
                            ID = 25,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7658),
                            Description = "Description for walk 25",
                            LengthInKm = 11.0,
                            Name = "Walk 25",
                            RegionID = 9,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7659)
                        },
                        new
                        {
                            ID = 26,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7661),
                            Description = "Description for walk 26",
                            LengthInKm = 8.0,
                            Name = "Walk 26",
                            RegionID = 7,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7662)
                        },
                        new
                        {
                            ID = 27,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7665),
                            Description = "Description for walk 27",
                            LengthInKm = 11.0,
                            Name = "Walk 27",
                            RegionID = 7,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7666)
                        },
                        new
                        {
                            ID = 28,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7668),
                            Description = "Description for walk 28",
                            LengthInKm = 7.0,
                            Name = "Walk 28",
                            RegionID = 5,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7669)
                        },
                        new
                        {
                            ID = 29,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7671),
                            Description = "Description for walk 29",
                            LengthInKm = 18.0,
                            Name = "Walk 29",
                            RegionID = 4,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7672)
                        },
                        new
                        {
                            ID = 30,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7675),
                            Description = "Description for walk 30",
                            LengthInKm = 12.0,
                            Name = "Walk 30",
                            RegionID = 4,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7676)
                        },
                        new
                        {
                            ID = 31,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7678),
                            Description = "Description for walk 31",
                            LengthInKm = 9.0,
                            Name = "Walk 31",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7679)
                        },
                        new
                        {
                            ID = 32,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7681),
                            Description = "Description for walk 32",
                            LengthInKm = 13.0,
                            Name = "Walk 32",
                            RegionID = 2,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7682)
                        },
                        new
                        {
                            ID = 33,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7684),
                            Description = "Description for walk 33",
                            LengthInKm = 19.0,
                            Name = "Walk 33",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7685)
                        },
                        new
                        {
                            ID = 34,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7689),
                            Description = "Description for walk 34",
                            LengthInKm = 19.0,
                            Name = "Walk 34",
                            RegionID = 6,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7690)
                        },
                        new
                        {
                            ID = 35,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7692),
                            Description = "Description for walk 35",
                            LengthInKm = 7.0,
                            Name = "Walk 35",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7693)
                        },
                        new
                        {
                            ID = 36,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7696),
                            Description = "Description for walk 36",
                            LengthInKm = 10.0,
                            Name = "Walk 36",
                            RegionID = 9,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7697)
                        },
                        new
                        {
                            ID = 37,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7699),
                            Description = "Description for walk 37",
                            LengthInKm = 16.0,
                            Name = "Walk 37",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7700)
                        },
                        new
                        {
                            ID = 38,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7702),
                            Description = "Description for walk 38",
                            LengthInKm = 3.0,
                            Name = "Walk 38",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7703)
                        },
                        new
                        {
                            ID = 39,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7705),
                            Description = "Description for walk 39",
                            LengthInKm = 9.0,
                            Name = "Walk 39",
                            RegionID = 2,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7706)
                        },
                        new
                        {
                            ID = 40,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7709),
                            Description = "Description for walk 40",
                            LengthInKm = 10.0,
                            Name = "Walk 40",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7710)
                        },
                        new
                        {
                            ID = 41,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7712),
                            Description = "Description for walk 41",
                            LengthInKm = 13.0,
                            Name = "Walk 41",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7713)
                        },
                        new
                        {
                            ID = 42,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7715),
                            Description = "Description for walk 42",
                            LengthInKm = 8.0,
                            Name = "Walk 42",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7716)
                        },
                        new
                        {
                            ID = 43,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7719),
                            Description = "Description for walk 43",
                            LengthInKm = 18.0,
                            Name = "Walk 43",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7720)
                        },
                        new
                        {
                            ID = 44,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7722),
                            Description = "Description for walk 44",
                            LengthInKm = 11.0,
                            Name = "Walk 44",
                            RegionID = 8,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7723)
                        },
                        new
                        {
                            ID = 45,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7725),
                            Description = "Description for walk 45",
                            LengthInKm = 9.0,
                            Name = "Walk 45",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7727)
                        },
                        new
                        {
                            ID = 46,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7729),
                            Description = "Description for walk 46",
                            LengthInKm = 2.0,
                            Name = "Walk 46",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7730)
                        },
                        new
                        {
                            ID = 47,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7732),
                            Description = "Description for walk 47",
                            LengthInKm = 19.0,
                            Name = "Walk 47",
                            RegionID = 1,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7733)
                        },
                        new
                        {
                            ID = 48,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7735),
                            Description = "Description for walk 48",
                            LengthInKm = 18.0,
                            Name = "Walk 48",
                            RegionID = 9,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7737)
                        },
                        new
                        {
                            ID = 49,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7739),
                            Description = "Description for walk 49",
                            LengthInKm = 6.0,
                            Name = "Walk 49",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7740)
                        },
                        new
                        {
                            ID = 50,
                            Created = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7774),
                            Description = "Description for walk 50",
                            LengthInKm = 18.0,
                            Name = "Walk 50",
                            RegionID = 3,
                            Updated = new DateTime(2024, 5, 16, 13, 54, 25, 625, DateTimeKind.Local).AddTicks(7775)
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
