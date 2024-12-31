﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using denemeodev;

#nullable disable

namespace denemeodev.Migrations
{
    [DbContext(typeof(OkulContext))]
    [Migration("20241228183558_CreateMigration")]
    partial class CreateMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("denemeodev.Ders", b =>
                {
                    b.Property<int>("DersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersId"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DersId");

                    b.ToTable("Dersler");

                    b.HasData(
                        new
                        {
                            DersId = 1,
                            Baslik = "İnternet Programcılığı"
                        },
                        new
                        {
                            DersId = 2,
                            Baslik = "Görsel Programlama"
                        },
                        new
                        {
                            DersId = 3,
                            Baslik = "Nesne Programlama"
                        },
                        new
                        {
                            DersId = 4,
                            Baslik = "İş Sağlığı ve Güvenliği"
                        },
                        new
                        {
                            DersId = 5,
                            Baslik = "Veri Tabanı"
                        },
                        new
                        {
                            DersId = 6,
                            Baslik = "Yapay Zeka"
                        },
                        new
                        {
                            DersId = 7,
                            Baslik = "Adli Bilişim"
                        },
                        new
                        {
                            DersId = 8,
                            Baslik = "Zaman Yönetimi"
                        },
                        new
                        {
                            DersId = 9,
                            Baslik = "ERP"
                        },
                        new
                        {
                            DersId = 10,
                            Baslik = "Donanım"
                        });
                });

            modelBuilder.Entity("denemeodev.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciId");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("denemeodev.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.HasKey("OgrenciId", "DersId");

                    b.HasIndex("DersId");

                    b.ToTable("OgrenciDersleri");
                });

            modelBuilder.Entity("denemeodev.Sinif", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.HasKey("SinifId");

                    b.ToTable("Siniflar");

                    b.HasData(
                        new
                        {
                            SinifId = 1,
                            Adi = "1. Sınıf",
                            Kapasite = 10
                        },
                        new
                        {
                            SinifId = 2,
                            Adi = "2. Sınıf",
                            Kapasite = 10
                        },
                        new
                        {
                            SinifId = 3,
                            Adi = "3. Sınıf",
                            Kapasite = 10
                        });
                });

            modelBuilder.Entity("denemeodev.Ogrenci", b =>
                {
                    b.HasOne("denemeodev.Sinif", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("denemeodev.OgrenciDers", b =>
                {
                    b.HasOne("denemeodev.Ders", "Ders")
                        .WithMany("OgrenciDersleri")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("denemeodev.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDersleri")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("denemeodev.Ders", b =>
                {
                    b.Navigation("OgrenciDersleri");
                });

            modelBuilder.Entity("denemeodev.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDersleri");
                });

            modelBuilder.Entity("denemeodev.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
