using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCV.Models.Entity
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SELINGOL\\MSSQLSERVER01;database=DbCV; integrated security=true");
        }
        public DbSet<TblAdmin> TblAdmins { get; set; }
        public DbSet<TblDeneyimlerim> TblDeneyimlerims { get; set; }
        public DbSet<TblEgitimlerim> TblEgitimlerims { get; set; }
        public DbSet<TblHakkimda> TblHakkimdas { get; set; }
        public DbSet<TblHobilerim> TblHobilerims { get; set; }
        public DbSet<TblIletisim> TblIletisims { get; set; }
        public DbSet<TblSertifikalarim> TblSertifikalarims { get; set; }
        public DbSet<TblSosyalMedya> TblSosyalMedyas { get; set; }
        public DbSet<TblYeteneklerim> TblYeteneklerims { get; set; }
    }

}

