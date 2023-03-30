using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDFirstLibrary.Models
{
    public partial class Ülkeler
    {
        [Key]
        public int UlkeId { get; set; }
        public string? UlkeAdi { get; set; }
    }
}
