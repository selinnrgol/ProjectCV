using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblSosyalMedya
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Link { get; set; }
        public string Ikon { get; set; }
        public Nullable<bool>Durum { get; set; }
    }
}
