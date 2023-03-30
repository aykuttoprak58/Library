using CDFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CDFirstLibrary.Controllers
{
    public class YazarlarController : Controller
    {

        private readonly Context context = new Context();



        public IActionResult Listele()
        {
            var xx = context.yazarlar.ToList();

            return View(xx);
        }


        public IActionResult Sil(int id)
        {
            var xx = context.yazarlar.Find(id);
            context.yazarlar.Remove(xx);
            context.SaveChanges();
            return RedirectToAction("Listele");
        }
    }
}
