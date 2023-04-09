﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiskSolution.Models.Context;

#nullable disable

namespace RiskSolution.Migrations
{
    [DbContext(typeof(RiskContext))]
    [Migration("20230409132246_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RiskSolution.Models.AccessibilityViolations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttackImplementation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceOfThreat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Threat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessibilityViolations");
                });

            modelBuilder.Entity("RiskSolution.Models.ConfidentialityViolations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttackImplementation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceOfThreat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Threat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConfidentialityViolations");
                });

            modelBuilder.Entity("RiskSolution.Models.IntegrityViolations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttackImplementation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceOfThreat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Threat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IntegrityViolations");
                });
#pragma warning restore 612, 618
        }
    }
}
