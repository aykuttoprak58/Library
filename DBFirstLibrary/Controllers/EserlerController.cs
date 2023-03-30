using DBFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstLibrary.Controllers
{
    public class EserlerController : Controller
    {

        private readonly db_libraryContext librarycontext;

        private Eserler eserler;

        public EserlerController(db_libraryContext librarycontext2)
        {

            librarycontext = librarycontext2;

        }

        public IActionResult Listele()
        {
            var xx = librarycontext.Eserlers.ToList();    

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
            librarycontext.Eserlers.Add(d);
            librarycontext.SaveChanges();       
            return RedirectToAction("Listele");
        }

        public IActionResult Sil(int id)
        {
            var xx = librarycontext.Eserlers.Find(id);  
            librarycontext.Eserlers.Remove(xx); 
            librarycontext.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Güncelle(int id)
        {
            var xx = librarycontext.Eserlers.Find(id);    

            return View(xx);
        }
        [HttpPost]
        public IActionResult Güncelle(Eserler d)
        {
            
            //var xx = librarycontext.Eserlers.Find(d.EserId);

            

            //xx.EserAdi = d.EserAdi;
            //xx.Kategori = d.Kategori;   
            //xx.Yazar = d.Yazar; 
            //xx.YayinTarihi = d.YayinTarihi;
            librarycontext.Eserlers.Update(d);  
            librarycontext.SaveChanges();
            return RedirectToAction("Listele");
        }



    }
}
