using Microsoft.EntityFrameworkCore;

namespace UrunTakipProjesi.Models
{
    public class UrunTakipContext : DbContext
    {
        public UrunTakipContext(DbContextOptions<UrunTakipContext> options) : base(options) { }

        public DbSet<Urun>? Urunler { get; set; }
        public DbSet<Kategori>? Kategoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { KategoriId = 1, KategoriAd = "Elektronik" },
                new Kategori { KategoriId = 2, KategoriAd = "Kırtasiye" }
            );

            modelBuilder.Entity<Urun>().HasData(
                new Urun { UrunId = 1, UrunAd = "Laptop", UrunFiyat = 5000, UrunAdet = 10, KategoriId = 1, UrunPhoto = "/images/laptop.jpg" },
                new Urun { UrunId = 2, UrunAd = "Mouse", UrunFiyat = 100, UrunAdet = 50, KategoriId = 1, UrunPhoto = "/images/mouse.jpg" },
                new Urun { UrunId = 3, UrunAd = "Telefon", UrunFiyat = 3000, UrunAdet = 20, KategoriId = 1, UrunPhoto = "/images/telefon.jpg" },
                new Urun { UrunId = 4, UrunAd = "Klavye", UrunFiyat = 200, UrunAdet = 30, KategoriId = 1, UrunPhoto = "/images/klavye.jpg" },
                new Urun { UrunId = 5, UrunAd = "Yazıcı", UrunFiyat = 800, UrunAdet = 15, KategoriId = 1, UrunPhoto = "/images/yazici.jpg" },
                new Urun { UrunId = 6, UrunAd = "Monitor", UrunFiyat = 1200, UrunAdet = 10, KategoriId = 1, UrunPhoto = "/images/monitor.jpg" },
                new Urun { UrunId = 7, UrunAd = "Kulaklık", UrunFiyat = 150, UrunAdet = 50, KategoriId = 1, UrunPhoto = "/images/kulaklik.jpg" },
                new Urun { UrunId = 8, UrunAd = "Hoparlör", UrunFiyat = 250, UrunAdet = 40, KategoriId = 1, UrunPhoto = "/images/hoparlor.jpg" },
                new Urun { UrunId = 9, UrunAd = "Tablet", UrunFiyat = 2000, UrunAdet = 25, KategoriId = 1, UrunPhoto = "/images/tablet.jpg" },
                new Urun { UrunId = 10, UrunAd = "USB Bellek", UrunFiyat = 50, UrunAdet = 100, KategoriId = 1, UrunPhoto = "/images/usb bellek.jpg" },
                new Urun { UrunId = 11, UrunAd = "Defter", UrunFiyat = 10, UrunAdet = 200, KategoriId = 2, UrunPhoto = "/images/defter.jpg" },
                new Urun { UrunId = 12, UrunAd = "Kalem", UrunFiyat = 5, UrunAdet = 300, KategoriId = 2, UrunPhoto = "/images/kalem.jpg" },
                new Urun { UrunId = 13, UrunAd = "Silgi", UrunFiyat = 2, UrunAdet = 150, KategoriId = 2, UrunPhoto = "/images/silgi.jpg" },
                new Urun { UrunId = 14, UrunAd = "Cetvel", UrunFiyat = 3, UrunAdet = 100, KategoriId = 2, UrunPhoto = "/images/cetvel.jpg" },
                new Urun { UrunId = 15, UrunAd = "Zimba", UrunFiyat = 25, UrunAdet = 50, KategoriId = 2, UrunPhoto = "/images/zimba.jpg" },
                new Urun { UrunId = 16, UrunAd = "Yapıştırıcı", UrunFiyat = 5, UrunAdet = 80, KategoriId = 2, UrunPhoto = "/images/yapistirici.jpg" },
                new Urun { UrunId = 17, UrunAd = "Çanta", UrunFiyat = 100, UrunAdet = 40, KategoriId = 2, UrunPhoto = "/images/canta.jpg" },
                new Urun { UrunId = 18, UrunAd = "Ajanda", UrunFiyat = 15, UrunAdet = 60, KategoriId = 2, UrunPhoto = "/images/ajanda.jpg" },
                new Urun { UrunId = 19, UrunAd = "Dosya", UrunFiyat = 7, UrunAdet = 90, KategoriId = 2, UrunPhoto = "/images/dosya.jpg" },
                new Urun { UrunId = 20, UrunAd = "Etiket", UrunFiyat = 1, UrunAdet = 200, KategoriId = 2, UrunPhoto = "/images/etiket.jpg" }
            );
        }
    }
}
