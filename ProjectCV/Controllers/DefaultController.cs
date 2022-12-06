using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCV.Models.Entity;


namespace ProjectCV.Controllers
{
    public class DefaultController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            var degerler = db.TblHakkimdas.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerims.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitimlerims.ToList();
            return PartialView(egitimler);
        }

    }
}
