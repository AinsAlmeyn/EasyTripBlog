using System;
using System.Collections.Generic;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}
