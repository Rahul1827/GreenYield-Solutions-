﻿// <auto-generated />
using System;
using GreenYieldSolutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenYieldSolutions.Migrations.CropAdvisoryDb
{
    [DbContext(typeof(CropAdvisoryDbContext))]
    partial class CropAdvisoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GreenYieldSolutions.Models.CropAdvisory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BaseFertilizer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CommonPests")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CropName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("FloweringStage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FruitingStage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("HarvestDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IrrigationFirst")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IrrigationFrequency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NutrientAmount")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NutrientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlowingMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecommendedEquipment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecommendedFertilizer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RecommendedPesticide")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RowSpacing")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SeedRate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SoilRequirement")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SoilType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SowingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StorageRecommendations")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Variety")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CropAdvisories");
                });
#pragma warning restore 612, 618
        }
    }
}
