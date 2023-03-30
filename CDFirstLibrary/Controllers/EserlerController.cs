using CDFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.Xml;

namespace CDFirstLibrary.Controllers
{
    public class EserlerController : Controller
    {

        private readonly Context context;
        private readonly DbSet<Eserler> eserlers;

        public EserlerController(Context context2)
        {
            context = context2;
            eserlers = context.Set<Eserler>();
        }

        [HttpGet]
        public IActionResult Listele()
        {
            var xx = context.eserler.ToList();

            //var xx = eserlers.ToList();

            return View(xx);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Eserler d)
        {
            //context.eserler.Add(d);
            eserlers.Add(d);
            context.SaveChanges();
            return RedirectToAction("Listele");
        }

        public IActionResult Sil(int id)
        {
            var xx = context.eserler.Find(id);
            context.eserler.Remove(xx);
            context.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Güncelle(int id)
        {
            var xx = context.eserler.Find(id);

            var yy = eserlers.Find(id);

            return View(yy);
        }
        [HttpPost]
        public IActionResult Güncelle(Eserler d)
        {

            var xx = context.eserler.Find(d.EserId);
            xx.EserAdi = d.EserAdi;
            xx.Kategori = d.Kategori;
            xx.Yazar = d.Yazar;
            xx.YayinTarihi = d.YayinTarihi;
            //eserlers.Update(d);
            context.SaveChanges();
            return RedirectToAction("Listele");





        }



    }
}
