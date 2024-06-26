using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrunTakipProjesi.Migrations
{
    public partial class UpdateProductNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunPhoto",
                table: "Urunler",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 10,
                column: "UrunPhoto",
                value: "usb bellek.jpg");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 15,
                columns: new[] { "UrunAd", "UrunPhoto" },
                values: new object[] { "Zımba", "zimba.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunPhoto",
                table: "Urunler",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 10,
                column: "UrunPhoto",
                value: "usb.jpg");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 15,
                columns: new[] { "UrunAd", "UrunPhoto" },
                values: new object[] { "Makastar", "makastar.jpg" });
        }
    }
}
