using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDFirstLibrary.Models
{
    public partial class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        public string? KategoriAdi { get; set; }
    }
}
