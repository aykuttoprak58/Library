using AdoLibrary.DAL;
using AdoLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AdoLibrary.Controllers
{
    public class EserlerController : Controller
    {
        private readonly EntityEserler Eserler;

        public EserlerController(EntityEserler eserler)
        {
            Eserler = eserler;
        }

        public IActionResult Listele()
        {

            //List<EntityEserler> eserler  = new List<EntityEserler>();
            var eserler = DalEserler.EserListesi();
            return View(eserler);       
        }


        [HttpGet]
        public IActionResult Ekle()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Ekle(EntityEserler eserler)
        {
            var xx = DalEserler.EserEkle(eserler);

            return RedirectToAction("Listele");       
        }


        [HttpGet]
        public IActionResult Silme(int id)
        {

            EntityEserler eserler = DalEserler.EserSilme(id); 
            return View(eserler);
        }



        [HttpPost]
        public IActionResult Sil(int id)
        {
           DalEserler.EserSil(id);

            return RedirectToAction("Listele");
        }

        [HttpGet]
        public IActionResult Güncelle(int id)
        {
            EntityEserler eserler = DalEserler.EserGüncelle(id);    
            return View(eserler);
        }
        [HttpPost]
        public IActionResult Güncelle(EntityEserler eserlerimm)
        {
             DalEserler.EserGüncelle(eserlerimm);

            return RedirectToAction("Listele");
        }

        //[HttpGet]
        //public IActionResult Sil(int id)
        //{

        //    EntityEserler eserler = DalEserler.EserSilme(id);
        //    return View(eserler);
        //}



        //[HttpPost]
        //public IActionResult Sil(EntityEserler model)
        //{
        //    DalEserler.EserSil(model.id);

        //    return RedirectToAction("Listele");
        //}

    }
}
