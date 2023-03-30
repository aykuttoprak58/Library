using CDFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CDFirstLibrary.Controllers
{
    public class UlkelerController : Controller
    {

        private readonly Context context = new Context();



        public IActionResult Listele()
        {
            var xx = context.ülkeler.ToList();

            return View(xx);
        }
    }
}
