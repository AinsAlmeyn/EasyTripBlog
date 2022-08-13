using System;
using System.Collections.Generic;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class Yorumlar
    {
        public int Id { get; set; }
        public string Kullaniciadi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int? Blogs { get; set; }

        public virtual Blog BlogsNavigation { get; set; }
    }
}
