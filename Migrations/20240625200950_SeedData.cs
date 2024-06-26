using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrunTakipProjesi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "KategoriAd" },
                values: new object[] { 1, "Elektronik" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "KategoriAd" },
                values: new object[] { 2, "Kırtasiye" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 1, 1, "Laptop", (short)10, 5000m, "laptop.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 2, 1, "Mouse", (short)50, 100m, "mouse.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 3, 1, "Telefon", (short)20, 3000m, "telefon.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 4, 1, "Klavye", (short)30, 200m, "klavye.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 5, 1, "Yazıcı", (short)15, 800m, "yazici.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 6, 1, "Monitor", (short)10, 1200m, "monitor.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 7, 1, "Kulaklık", (short)50, 150m, "kulaklik.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 8, 1, "Hoparlör", (short)40, 250m, "hoparlor.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 9, 1, "Tablet", (short)25, 2000m, "tablet.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 10, 1, "USB Bellek", (short)100, 50m, "usb.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 11, 2, "Defter", (short)200, 10m, "defter.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 12, 2, "Kalem", (short)300, 5m, "kalem.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 13, 2, "Silgi", (short)150, 2m, "silgi.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 14, 2, "Cetvel", (short)100, 3m, "cetvel.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 15, 2, "Makastar", (short)50, 25m, "makastar.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 16, 2, "Yapıştırıcı", (short)80, 5m, "yapistirici.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 17, 2, "Çanta", (short)40, 100m, "canta.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 18, 2, "Ajanda", (short)60, 15m, "ajanda.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 19, 2, "Dosya", (short)90, 7m, "dosya.jpg" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "KategoriId", "UrunAd", "UrunAdet", "UrunFiyat", "UrunPhoto" },
                values: new object[] { 20, 2, "Etiket", (short)200, 1m, "etiket.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "KategoriId",
                keyValue: 2);
        }
    }
}
