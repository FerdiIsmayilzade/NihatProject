using Microsoft.AspNetCore.Mvc;

namespace E_Come.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
