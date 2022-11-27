using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblHakkimda
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
    }
}
