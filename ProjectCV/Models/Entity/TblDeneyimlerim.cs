using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblDeneyimlerim
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
