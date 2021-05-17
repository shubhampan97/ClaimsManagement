﻿// <auto-generated />
using System;
using MemberPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MemberPortal.Migrations
{
    [DbContext(typeof(MockDbContext))]
    [Migration("20201106161119_client6")]
    partial class client6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MemberPortal.Models.MockDatabase", b =>
                {
                    b.Property<Guid>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BenefitID")
                        .HasColumnType("int");

                    b.Property<string>("BenefitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ClaimAmount")
                        .HasColumnType("float");

                    b.Property<int>("ClaimID")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("PolicyID")
                        .HasColumnType("int");

                    b.HasKey("TransactionID");

                    b.ToTable("MockDatabases");
                });
#pragma warning restore 612, 618
        }
    }
}
