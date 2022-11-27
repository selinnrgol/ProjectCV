using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblSertifikalarim
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
