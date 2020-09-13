﻿// <auto-generated />

using System;
using EmployeeAppWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeAppWebApi.Data.migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeAppWebApi.Models.Employee", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("AmountOfKids")
                    .HasColumnType("int");

                b.Property<DateTime>("BornYear")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("CreatedAt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2");

                b.Property<string>("FullName")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("Gender")
                    .HasColumnType("bit");

                b.Property<bool>("HasKids")
                    .HasColumnType("bit");

                b.Property<bool>("IsMarried")
                    .HasColumnType("bit");

                b.Property<Guid?>("UnitId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("UpdatedAt")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("UnitId");

                b.ToTable("Employees");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Payment", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2");

                b.Property<DateTime>("Date")
                    .HasColumnType("datetime2");

                b.Property<Guid?>("EmployeeId")
                    .HasColumnType("uniqueidentifier");

                b.Property<decimal>("PaymentAmount")
                    .HasColumnType("money");

                b.Property<DateTime>("UpdatedAt")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("EmployeeId");

                b.ToTable("Payments");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Position", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2");

                b.Property<decimal>("DailySalary")
                    .HasColumnType("money");

                b.Property<Guid>("EmployeeId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid?>("UnitId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("UpdatedAt")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("EmployeeId")
                    .IsUnique();

                b.HasIndex("UnitId");

                b.ToTable("Positions");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Unit", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("UpdatedAt")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Units");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Employee", b =>
            {
                b.HasOne("EmployeeAppWebApi.Models.Unit", "Unit")
                    .WithMany()
                    .HasForeignKey("UnitId");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Payment", b =>
            {
                b.HasOne("EmployeeAppWebApi.Models.Employee", "Employee")
                    .WithMany("Payments")
                    .HasForeignKey("EmployeeId");
            });

            modelBuilder.Entity("EmployeeAppWebApi.Models.Position", b =>
            {
                b.HasOne("EmployeeAppWebApi.Models.Employee", "Employee")
                    .WithOne("Position")
                    .HasForeignKey("EmployeeAppWebApi.Models.Position", "EmployeeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("EmployeeAppWebApi.Models.Unit", "Unit")
                    .WithMany("Positions")
                    .HasForeignKey("UnitId");
            });
#pragma warning restore 612, 618
        }
    }
}