﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLSK.Database;

#nullable disable

namespace QLSK.Migrations
{
    [DbContext(typeof(QLSKContext))]
    [Migration("20220802055240_Intitial Create")]
    partial class IntitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QLSK.Database.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("QLSK.Database.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("QLSK.Database.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("DayEnd")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DayStart")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Link")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Require")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeEvent")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("QLSK.Database.Registration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("EID")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhieuDKSK");
                });

            modelBuilder.Entity("QLSK.Database.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("char(20)");

                    b.Property<bool?>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
