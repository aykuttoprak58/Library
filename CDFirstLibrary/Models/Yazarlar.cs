using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDFirstLibrary.Models
{
    public partial class Yazarlar
    {
        [Key]
        public int YazarId { get; set; }
        public string? YazarAdi { get; set; }
        public int? YazarYasi { get; set; }
        public int? YazarUlkesi { get; set; }
    }
}
