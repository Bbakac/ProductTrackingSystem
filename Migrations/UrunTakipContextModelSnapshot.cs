﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrunTakipProjesi.Models;

#nullable disable

namespace UrunTakipProjesi.Migrations
{
    [DbContext(typeof(UrunTakipContext))]
    partial class UrunTakipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("UrunTakipProjesi.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            KategoriId = 1,
                            KategoriAd = "Elektronik"
                        },
                        new
                        {
                            KategoriId = 2,
                            KategoriAd = "Kırtasiye"
                        });
                });

            modelBuilder.Entity("UrunTakipProjesi.Models.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KategoriId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<short>("UrunAdet")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UrunFiyat")
                        .HasColumnType("money");

                    b.Property<string>("UrunPhoto")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            UrunId = 1,
                            KategoriId = 1,
                            UrunAd = "Laptop",
                            UrunAdet = (short)10,
                            UrunFiyat = 5000m,
                            UrunPhoto = "laptop.jpg"
                        },
                        new
                        {
                            UrunId = 2,
                            KategoriId = 1,
                            UrunAd = "Mouse",
                            UrunAdet = (short)50,
                            UrunFiyat = 100m,
                            UrunPhoto = "mouse.jpg"
                        },
                        new
                        {
                            UrunId = 3,
                            KategoriId = 1,
                            UrunAd = "Telefon",
                            UrunAdet = (short)20,
                            UrunFiyat = 3000m,
                            UrunPhoto = "telefon.jpg"
                        },
                        new
                        {
                            UrunId = 4,
                            KategoriId = 1,
                            UrunAd = "Klavye",
                            UrunAdet = (short)30,
                            UrunFiyat = 200m,
                            UrunPhoto = "klavye.jpg"
                        },
                        new
                        {
                            UrunId = 5,
                            KategoriId = 1,
                            UrunAd = "Yazıcı",
                            UrunAdet = (short)15,
                            UrunFiyat = 800m,
                            UrunPhoto = "yazici.jpg"
                        },
                        new
                        {
                            UrunId = 6,
                            KategoriId = 1,
                            UrunAd = "Monitor",
                            UrunAdet = (short)10,
                            UrunFiyat = 1200m,
                            UrunPhoto = "monitor.jpg"
                        },
                        new
                        {
                            UrunId = 7,
                            KategoriId = 1,
                            UrunAd = "Kulaklık",
                            UrunAdet = (short)50,
                            UrunFiyat = 150m,
                            UrunPhoto = "kulaklik.jpg"
                        },
                        new
                        {
                            UrunId = 8,
                            KategoriId = 1,
                            UrunAd = "Hoparlör",
                            UrunAdet = (short)40,
                            UrunFiyat = 250m,
                            UrunPhoto = "hoparlor.jpg"
                        },
                        new
                        {
                            UrunId = 9,
                            KategoriId = 1,
                            UrunAd = "Tablet",
                            UrunAdet = (short)25,
                            UrunFiyat = 2000m,
                            UrunPhoto = "tablet.jpg"
                        },
                        new
                        {
                            UrunId = 10,
                            KategoriId = 1,
                            UrunAd = "USB Bellek",
                            UrunAdet = (short)100,
                            UrunFiyat = 50m,
                            UrunPhoto = "usb bellek.jpg"
                        },
                        new
                        {
                            UrunId = 11,
                            KategoriId = 2,
                            UrunAd = "Defter",
                            UrunAdet = (short)200,
                            UrunFiyat = 10m,
                            UrunPhoto = "defter.jpg"
                        },
                        new
                        {
                            UrunId = 12,
                            KategoriId = 2,
                            UrunAd = "Kalem",
                            UrunAdet = (short)300,
                            UrunFiyat = 5m,
                            UrunPhoto = "kalem.jpg"
                        },
                        new
                        {
                            UrunId = 13,
                            KategoriId = 2,
                            UrunAd = "Silgi",
                            UrunAdet = (short)150,
                            UrunFiyat = 2m,
                            UrunPhoto = "silgi.jpg"
                        },
                        new
                        {
                            UrunId = 14,
                            KategoriId = 2,
                            UrunAd = "Cetvel",
                            UrunAdet = (short)100,
                            UrunFiyat = 3m,
                            UrunPhoto = "cetvel.jpg"
                        },
                        new
                        {
                            UrunId = 15,
                            KategoriId = 2,
                            UrunAd = "Zımba",
                            UrunAdet = (short)50,
                            UrunFiyat = 25m,
                            UrunPhoto = "zimba.jpg"
                        },
                        new
                        {
                            UrunId = 16,
                            KategoriId = 2,
                            UrunAd = "Yapıştırıcı",
                            UrunAdet = (short)80,
                            UrunFiyat = 5m,
                            UrunPhoto = "yapistirici.jpg"
                        },
                        new
                        {
                            UrunId = 17,
                            KategoriId = 2,
                            UrunAd = "Çanta",
                            UrunAdet = (short)40,
                            UrunFiyat = 100m,
                            UrunPhoto = "canta.jpg"
                        },
                        new
                        {
                            UrunId = 18,
                            KategoriId = 2,
                            UrunAd = "Ajanda",
                            UrunAdet = (short)60,
                            UrunFiyat = 15m,
                            UrunPhoto = "ajanda.jpg"
                        },
                        new
                        {
                            UrunId = 19,
                            KategoriId = 2,
                            UrunAd = "Dosya",
                            UrunAdet = (short)90,
                            UrunFiyat = 7m,
                            UrunPhoto = "dosya.jpg"
                        },
                        new
                        {
                            UrunId = 20,
                            KategoriId = 2,
                            UrunAd = "Etiket",
                            UrunAdet = (short)200,
                            UrunFiyat = 1m,
                            UrunPhoto = "etiket.jpg"
                        });
                });

            modelBuilder.Entity("UrunTakipProjesi.Models.Urun", b =>
                {
                    b.HasOne("UrunTakipProjesi.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("UrunTakipProjesi.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
