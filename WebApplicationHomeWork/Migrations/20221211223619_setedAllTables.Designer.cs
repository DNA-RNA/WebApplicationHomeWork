﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationHomeWork.Data;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221211223619_setedAllTables")]
    partial class setedAllTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplicationHomeWork.Models.Bolum", b =>
                {
                    b.Property<int>("BolumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BolumId"));

                    b.Property<string>("BolumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BolumId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Duyuru", b =>
                {
                    b.Property<int>("DuyuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DuyuruId"));

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DuyuruId");

                    b.ToTable("announcements");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Oda", b =>
                {
                    b.Property<int>("OdaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdaId"));

                    b.Property<string>("OdaTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YatakId")
                        .HasColumnType("int");

                    b.HasKey("OdaId");

                    b.HasIndex("YatakId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Odeme", b =>
                {
                    b.Property<int>("OdemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdemeId"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OdemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("OdemeTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeliId")
                        .HasColumnType("int");

                    b.HasKey("OdemeId");

                    b.HasIndex("VeliId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumId")
                        .HasColumnType("int");

                    b.Property<string>("KapiSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciNo")
                        .HasColumnType("int");

                    b.Property<int>("OkulId")
                        .HasColumnType("int");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sınıf")
                        .HasColumnType("int");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeliId")
                        .HasColumnType("int");

                    b.HasKey("OgrenciId");

                    b.HasIndex("BolumId");

                    b.HasIndex("OdaId");

                    b.HasIndex("OkulId");

                    b.HasIndex("VeliId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.OgrenciSorun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int>("SorunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.HasIndex("SorunId");

                    b.ToTable("studentproblems");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Okul", b =>
                {
                    b.Property<int>("OkulId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OkulId"));

                    b.Property<string>("OkulName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OkulId");

                    b.ToTable("schools");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Sorun", b =>
                {
                    b.Property<int>("SorunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SorunId"));

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SorunId");

                    b.ToTable("problems");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Veli", b =>
                {
                    b.Property<int>("VeliId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VeliId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IbanNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OdemeId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeliId");

                    b.HasIndex("OdemeId");

                    b.ToTable("conservator");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Yatak", b =>
                {
                    b.Property<int>("YatakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YatakId"));

                    b.Property<string>("YatakSırası")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YatakId");

                    b.ToTable("beds");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Yemek", b =>
                {
                    b.Property<int>("YemekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekId"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YemekTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YemekId");

                    b.ToTable("foods");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Oda", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Yatak", "Yatak")
                        .WithMany("Odalar")
                        .HasForeignKey("YatakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yatak");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Odeme", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Veli", "Veli")
                        .WithMany()
                        .HasForeignKey("VeliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Ogrenci", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Bolum", "Bolum")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("BolumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationHomeWork.Models.Oda", "Oda")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("OdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationHomeWork.Models.Okul", "Okul")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationHomeWork.Models.Veli", "Veli")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("VeliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");

                    b.Navigation("Oda");

                    b.Navigation("Okul");

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.OgrenciSorun", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Ogrenci", "Ogrenci")
                        .WithMany()
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationHomeWork.Models.Sorun", "Sorun")
                        .WithMany()
                        .HasForeignKey("SorunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");

                    b.Navigation("Sorun");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Veli", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Odeme", null)
                        .WithMany("Veliler")
                        .HasForeignKey("OdemeId");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Bolum", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Oda", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Odeme", b =>
                {
                    b.Navigation("Veliler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Okul", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Veli", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Yatak", b =>
                {
                    b.Navigation("Odalar");
                });
#pragma warning restore 612, 618
        }
    }
}
