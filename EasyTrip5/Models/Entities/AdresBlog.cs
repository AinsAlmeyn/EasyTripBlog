using System;
using System.Collections.Generic;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class AdresBlog
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Adresacik { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}
