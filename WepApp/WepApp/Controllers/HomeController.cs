using Microsoft.AspNetCore.Mvc;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
