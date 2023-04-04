using Microsoft.AspNetCore.Mvc;

namespace CDFirstLibrary.Controllers
{
    public class KategorilerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
