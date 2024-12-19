using Microsoft.AspNetCore.Mvc;

namespace E_Come.Controllers
{
    public class FAQsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
