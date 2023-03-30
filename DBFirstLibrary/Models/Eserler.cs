using System;
using System.Collections.Generic;

namespace DBFirstLibrary.Models
{
    public partial class Eserler
    {
        public int EserId { get; set; }
        public string? EserAdi { get; set; }
        public int? Yazar { get; set; }
        public int? Kategori { get; set; }
        public int? YayinTarihi { get; set; }
    }
}
