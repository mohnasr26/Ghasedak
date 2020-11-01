﻿// <auto-generated />
using System;
using Ghasedak.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ghasedak.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191213090250_sdfas")]
    partial class sdfas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ghasedak.Models.AboutUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("id");

                    b.ToTable("AboutUss");
                });

            modelBuilder.Entity("Ghasedak.Models.Box", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("assignmentDate")
                        .HasMaxLength(20);

                    b.Property<int>("dischargeRouteId");

                    b.Property<string>("fullName")
                        .HasMaxLength(100);

                    b.Property<string>("mobile")
                        .HasMaxLength(11);

                    b.Property<string>("number")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.HasIndex("dischargeRouteId");

                    b.ToTable("Boxs");
                });

            modelBuilder.Entity("Ghasedak.Models.BoxIncome", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("boxId");

                    b.Property<string>("factorNumber")
                        .HasMaxLength(20);

                    b.Property<double>("lat");

                    b.Property<double>("lon");

                    b.Property<long>("price");

                    b.Property<string>("registerDate")
                        .HasMaxLength(20);

                    b.Property<int>("status");

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("boxId");

                    b.HasIndex("userId");

                    b.ToTable("BoxIncomes");
                });

            modelBuilder.Entity("Ghasedak.Models.ContactUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("androidVersion")
                        .HasMaxLength(20);

                    b.Property<string>("email")
                        .HasMaxLength(200);

                    b.Property<string>("pageInstagramUrl")
                        .HasMaxLength(200);

                    b.Property<string>("pageTelegramUrl")
                        .HasMaxLength(200);

                    b.Property<string>("pageTwitterUrl")
                        .HasMaxLength(200);

                    b.Property<string>("phone")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("ContactUss");
                });

            modelBuilder.Entity("Ghasedak.Models.DischargeRoute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(500);

                    b.Property<string>("code")
                        .HasMaxLength(10);

                    b.Property<int?>("day")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("DischargeRoutes");
                });

            modelBuilder.Entity("Ghasedak.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleNameEn")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RoleNameFa")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Ghasedak.Models.Rule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Ghasedak.Models.Setting", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("countExpireDate");

                    b.Property<int?>("countExpireDateIsespacial");

                    b.Property<string>("wrongWord")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Ghasedak.Models.Slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("image")
                        .HasMaxLength(500);

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Ghasedak.Models.Stir", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.HasKey("id");

                    b.ToTable("Stirs");
                });

            modelBuilder.Entity("Ghasedak.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code")
                        .HasMaxLength(6);

                    b.Property<string>("fullName")
                        .HasMaxLength(100);

                    b.Property<string>("password")
                        .HasMaxLength(200);

                    b.Property<string>("passwordShow")
                        .HasMaxLength(20);

                    b.Property<int>("roleId");

                    b.Property<string>("token")
                        .HasMaxLength(100);

                    b.Property<string>("userName")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ghasedak.Models.Box", b =>
                {
                    b.HasOne("Ghasedak.Models.DischargeRoute", "dischargeRoute")
                        .WithMany()
                        .HasForeignKey("dischargeRouteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Ghasedak.Models.BoxIncome", b =>
                {
                    b.HasOne("Ghasedak.Models.Box", "box")
                        .WithMany()
                        .HasForeignKey("boxId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Ghasedak.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.User", b =>
                {
                    b.HasOne("Ghasedak.Models.Role", "role")
                        .WithMany("Users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}