using DBFirstLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstLibrary.Controllers
{
    public class UlkelerController : Controller
    {
        private readonly db_libraryContext librarycontext;
        public UlkelerController(db_libraryContext librarycontext2)
        {

            librarycontext = librarycontext2;

        }

        public IActionResult Listele()
        {
            var xx = librarycontext.Ülkelers.ToList();

            return View(xx);
        }
    }
}
