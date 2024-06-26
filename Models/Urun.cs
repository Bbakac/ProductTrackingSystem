using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace UrunTakipProjesi.Models
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Required]
        [StringLength(50)]
        public string UrunAd { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "money")]
        public decimal UrunFiyat { get; set; }

        [Required]
        public short UrunAdet { get; set; }

        [StringLength(100)]
        public string? UrunPhoto { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public virtual Kategori? Kategori { get; set; }
    }
}
