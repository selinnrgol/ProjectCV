using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblYeteneklerim
    {
        [Key]
        public int ID { get; set; }
        public string Yetenek { get; set; }
        public Nullable<byte> Oran { get; set; }
    }
}
