﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class TblHobilerim
    {
        [Key]
        public int ID { get; set; }
        public string Aciklama1 { get; set; }
        public string Aciklama2 { get; set; }
    }
}
