using System;
using System.Collections.Generic;

namespace DBFirstLibrary.Models
{
    public partial class Yazarlar
    {
        public int YazarId { get; set; }
        public string? YazarAdi { get; set; }
        public int? YazarYasi { get; set; }
        public int? YazarUlkesi { get; set; }
    }
}
