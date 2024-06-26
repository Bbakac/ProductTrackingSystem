using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UrunTakipProjesi.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [Required]
        [StringLength(50)]
        public string KategoriAd { get; set; } = string.Empty;

        public ICollection<Urun>? Urunler { get; set; }
    }
}
