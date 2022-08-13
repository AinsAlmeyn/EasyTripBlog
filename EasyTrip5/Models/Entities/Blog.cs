using System;
using System.Collections.Generic;

#nullable disable

namespace EasyTrip5.Models.Entities
{
    public partial class Blog
    {
        public Blog()
        {
            //Yorumlars = new HashSet<Yorumlar>();
        }

        public int Id { get; set; }
        public string Baslik { get; set; }
        public DateTime? Tarih { get; set; }
        public string Aciklama { get; set; }
        public string Blogimage { get; set; }

        public virtual ICollection<Yorumlar> Yorumlars { get; set; }
    }
}