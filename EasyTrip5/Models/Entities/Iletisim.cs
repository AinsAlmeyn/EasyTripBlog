using System;
using System.Collections.Generic;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class Iletisim
    {
        public int Id { get; set; }
        public string Adsoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}
