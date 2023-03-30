using DBFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstLibrary.Controllers
{
    public class YazarlarController : Controller
    {
        private readonly db_libraryContext librarycontext;

        public YazarlarController(db_libraryContext librarycontext2)
        {

            librarycontext = librarycontext2;

        }


        public IActionResult Listele()
        {
            var xx = librarycontext.Yazarlars.ToList();

            return View(xx);
        }
    }
}
