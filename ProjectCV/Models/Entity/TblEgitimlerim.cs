using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblEgitimlerim
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik1 { get; set; }
        public string AltBaslik2 { get; set; }
        public string GNO { get; set; }
        public string Tarih { get; set; }
    }
}
