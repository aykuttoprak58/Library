using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDFirstLibrary.Models
{
    public partial class Eserler
    {
        [Key]
        public int EserId { get; set; }
        public string? EserAdi { get; set; }
        public int? Yazar { get; set; }
        public int? Kategori { get; set; }
        public int? YayinTarihi { get; set; }
    }
}
