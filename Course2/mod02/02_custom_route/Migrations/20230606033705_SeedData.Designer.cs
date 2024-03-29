﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterM.Data;

#nullable disable

namespace StarterM.Migrations
{
    [DbContext(typeof(OperaContext))]
    [Migration("20230606033705_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StarterM.Models.Opera", b =>
                {
                    b.Property<int>("OperaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperaID"), 1L, 1);

                    b.Property<string>("Composer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("OperaID");

                    b.ToTable("Operas");

                    b.HasData(
                        new
                        {
                            OperaID = 1,
                            Composer = "Wolfgang Amadeus Mozart",
                            Title = "Cosi Fan Tutte",
                            Year = 1790
                        },
                        new
                        {
                            OperaID = 2,
                            Composer = "Giuseppe Verdi",
                            Title = "Rigoletto",
                            Year = 1851
                        },
                        new
                        {
                            OperaID = 3,
                            Composer = "John Adams",
                            Title = "Nixon in China",
                            Year = 1987
                        },
                        new
                        {
                            OperaID = 4,
                            Composer = "Alban Berg",
                            Title = "Wozzeck",
                            Year = 1922
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
