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
    [Migration("20201122065044_sdfv")]
    partial class sdfv
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
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

            modelBuilder.Entity("Ghasedak.Models.AndroidVersion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("appAndroidUrl")
                        .HasMaxLength(70);

                    b.Property<string>("currVersion")
                        .HasMaxLength(20);

                    b.Property<bool>("isMandatory");

                    b.HasKey("id");

                    b.ToTable("AndroidVersions");
                });

            modelBuilder.Entity("Ghasedak.Models.Box", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(500);

                    b.Property<string>("assignmentDate")
                        .HasMaxLength(30);

                    b.Property<int>("charityId");

                    b.Property<int>("dischargeRouteId");

                    b.Property<string>("fullName")
                        .HasMaxLength(100);

                    b.Property<double>("lat");

                    b.Property<double>("lon");

                    b.Property<string>("mobile")
                        .HasMaxLength(11);

                    b.Property<string>("number")
                        .HasMaxLength(10);

                    b.Property<int?>("opratorId");

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

                    b.Property<int>("charityId");

                    b.Property<double>("lat");

                    b.Property<double>("lon");

                    b.Property<int>("opratorId");

                    b.Property<long?>("price");

                    b.Property<string>("registerDate")
                        .HasMaxLength(30);

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.HasIndex("boxId");

                    b.HasIndex("opratorId");

                    b.ToTable("BoxIncomes");
                });

            modelBuilder.Entity("Ghasedak.Models.Charity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(500);

                    b.Property<string>("androidCode")
                        .HasMaxLength(6);

                    b.Property<string>("code")
                        .HasMaxLength(6);

                    b.Property<string>("description")
                        .HasMaxLength(500);

                    b.Property<bool>("isAccessBox");

                    b.Property<bool>("isAccessFinancialAid");

                    b.Property<bool>("isAccessFlowerCrown");

                    b.Property<bool>("isAccessSponsor");

                    b.Property<bool>("isActive");

                    b.Property<string>("mobile")
                        .HasMaxLength(11);

                    b.Property<string>("password")
                        .HasMaxLength(200);

                    b.Property<string>("passwordShow")
                        .HasMaxLength(20);

                    b.Property<string>("title")
                        .HasMaxLength(30);

                    b.Property<string>("userName")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Charitys");
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

            modelBuilder.Entity("Ghasedak.Models.DeceasedName", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("deceaseAalias")
                        .HasMaxLength(100);

                    b.Property<string>("deceasedFullName")
                        .HasMaxLength(100);

                    b.Property<bool>("deceasedSex");

                    b.Property<Guid>("guid");

                    b.HasKey("id");

                    b.ToTable("DeceasedNames");
                });

            modelBuilder.Entity("Ghasedak.Models.DischargeRoute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(500);

                    b.Property<int>("charityId");

                    b.Property<string>("code")
                        .HasMaxLength(10);

                    b.Property<int?>("day");

                    b.Property<int?>("opratorId");

                    b.HasKey("id");

                    b.HasIndex("charityId");

                    b.ToTable("DischargeRoutes");
                });

            modelBuilder.Entity("Ghasedak.Models.Donator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("donatorAlias")
                        .HasMaxLength(100);

                    b.Property<string>("donatorFullName")
                        .HasMaxLength(100);

                    b.Property<string>("donatorMobile")
                        .HasMaxLength(11);

                    b.Property<Guid>("guid");

                    b.Property<bool>("isSendMessage");

                    b.HasKey("id");

                    b.ToTable("Donators");
                });

            modelBuilder.Entity("Ghasedak.Models.FinancialAid", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("charityId");

                    b.Property<int>("financialServiceTypeId");

                    b.Property<string>("name")
                        .HasMaxLength(100);

                    b.Property<int?>("opratorId");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("charityId");

                    b.HasIndex("financialServiceTypeId");

                    b.ToTable("FinancialAids");
                });

            modelBuilder.Entity("Ghasedak.Models.FinancialServiceType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("title")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("FinancialServiceTypes");
                });

            modelBuilder.Entity("Ghasedak.Models.FlowerCrown", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CeremonyType");

                    b.Property<int>("IntroducedId");

                    b.Property<int?>("charityId");

                    b.Property<int>("deceasedNameId");

                    b.Property<int>("donatorId");

                    b.Property<int>("flowerCrownTypeId");

                    b.Property<int?>("opratorId");

                    b.Property<long>("price");

                    b.Property<string>("registerDate")
                        .HasMaxLength(30);

                    b.HasKey("id");

                    b.HasIndex("charityId");

                    b.HasIndex("deceasedNameId");

                    b.HasIndex("flowerCrownTypeId");

                    b.ToTable("FlowerCrowns");
                });

            modelBuilder.Entity("Ghasedak.Models.FlowerCrownType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("title")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("FlowerCrownTypes");
                });

            modelBuilder.Entity("Ghasedak.Models.Oprator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("code")
                        .HasMaxLength(30);

                    b.Property<string>("fullName")
                        .HasMaxLength(100);

                    b.Property<bool>("isActive");

                    b.Property<string>("mobile")
                        .HasMaxLength(11);

                    b.Property<string>("password")
                        .HasMaxLength(200);

                    b.Property<string>("passwordShow")
                        .HasMaxLength(20);

                    b.Property<string>("token")
                        .HasMaxLength(100);

                    b.Property<string>("userName")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.HasIndex("charityId");

                    b.ToTable("Oprators");
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

                    b.Property<string>("logoName")
                        .HasMaxLength(500);

                    b.Property<string>("sherkatName")
                        .HasMaxLength(500);

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

            modelBuilder.Entity("Ghasedak.Models.Sponsor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(500);

                    b.Property<string>("birthDate")
                        .HasMaxLength(30);

                    b.Property<int>("charityId");

                    b.Property<string>("fullName")
                        .HasMaxLength(100);

                    b.Property<string>("mobile")
                        .HasMaxLength(11);

                    b.Property<string>("nationalcode")
                        .HasMaxLength(10);

                    b.Property<int>("opratorId");

                    b.Property<string>("phone")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.HasIndex("charityId");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("Ghasedak.Models.SponsorPay", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<string>("description")
                        .HasMaxLength(500);

                    b.Property<string>("deviceCode")
                        .HasMaxLength(30);

                    b.Property<int>("opratorId");

                    b.Property<long?>("price");

                    b.Property<string>("recieverCode")
                        .HasMaxLength(30);

                    b.Property<int>("sponsorId");

                    b.Property<string>("terminalCode")
                        .HasMaxLength(30);

                    b.HasKey("id");

                    b.HasIndex("sponsorId");

                    b.ToTable("SponsorPays");
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

            modelBuilder.Entity("Ghasedak.Models.UserActivity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("charityId");

                    b.Property<DateTime>("date");

                    b.Property<string>("description")
                        .HasMaxLength(500);

                    b.Property<int?>("opratorId");

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.HasIndex("opratorId");

                    b.ToTable("UserActivities");
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

                    b.HasOne("Ghasedak.Models.Oprator", "oprator")
                        .WithMany()
                        .HasForeignKey("opratorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.DischargeRoute", b =>
                {
                    b.HasOne("Ghasedak.Models.Charity", "Charity")
                        .WithMany()
                        .HasForeignKey("charityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.FinancialAid", b =>
                {
                    b.HasOne("Ghasedak.Models.Charity", "Charity")
                        .WithMany()
                        .HasForeignKey("charityId");

                    b.HasOne("Ghasedak.Models.FinancialServiceType", "FinancialServiceType")
                        .WithMany()
                        .HasForeignKey("financialServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.FlowerCrown", b =>
                {
                    b.HasOne("Ghasedak.Models.Charity", "Charity")
                        .WithMany()
                        .HasForeignKey("charityId");

                    b.HasOne("Ghasedak.Models.DeceasedName", "DeceasedName")
                        .WithMany()
                        .HasForeignKey("deceasedNameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ghasedak.Models.FlowerCrownType", "FlowerCrownType")
                        .WithMany()
                        .HasForeignKey("flowerCrownTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.Oprator", b =>
                {
                    b.HasOne("Ghasedak.Models.Charity", "Charity")
                        .WithMany()
                        .HasForeignKey("charityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.Sponsor", b =>
                {
                    b.HasOne("Ghasedak.Models.Charity", "Charity")
                        .WithMany()
                        .HasForeignKey("charityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.SponsorPay", b =>
                {
                    b.HasOne("Ghasedak.Models.Sponsor", "Sponsor")
                        .WithMany()
                        .HasForeignKey("sponsorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.User", b =>
                {
                    b.HasOne("Ghasedak.Models.Role", "role")
                        .WithMany("Users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ghasedak.Models.UserActivity", b =>
                {
                    b.HasOne("Ghasedak.Models.Oprator", "oprator")
                        .WithMany()
                        .HasForeignKey("opratorId");
                });
#pragma warning restore 612, 618
        }
    }
}
