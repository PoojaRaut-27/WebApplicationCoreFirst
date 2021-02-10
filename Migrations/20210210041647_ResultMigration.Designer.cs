﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationCoreFirst.Data;

namespace WebApplicationCoreFirst.Migrations
{
    [DbContext(typeof(StudMarksheetContext))]
    [Migration("20210210041647_ResultMigration")]
    partial class ResultMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WebApplicationCoreFirst.Data.StudResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BoardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Greeting")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("M1")
                        .HasColumnType("int");

                    b.Property<int>("M2")
                        .HasColumnType("int");

                    b.Property<int>("M3")
                        .HasColumnType("int");

                    b.Property<int>("RollNo")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StudResult");
                });
#pragma warning restore 612, 618
        }
    }
}