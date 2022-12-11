﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationHomeWork.Data;

#nullable disable

namespace WebApplicationHomeWork.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("WebApplicationHomeWork.Models.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciNo")
                        .HasColumnType("int");

                    b.Property<int>("OkulId")
                        .HasColumnType("int");

                    b.Property<string>("PassportNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sınıf")
                        .HasColumnType("int");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolumId");

                    b.HasIndex("OkulId");

                    b.ToTable("Ogrenci");
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

            modelBuilder.Entity("WebApplicationHomeWork.Models.Veli", b =>
                {
                    b.Property<int>("VeliId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VeliId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("VeliAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VeliSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeliId");

                    b.ToTable("conservator");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Ogrenci", b =>
                {
                    b.HasOne("WebApplicationHomeWork.Models.Bolum", "Bolum")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("BolumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationHomeWork.Models.Okul", "Okul")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");

                    b.Navigation("Okul");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Bolum", b =>
                {
                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("WebApplicationHomeWork.Models.Okul", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
