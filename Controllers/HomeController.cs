using Microsoft.AspNetCore.Mvc;

namespace MarketDemo.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
       { 
            return View(); 
       }
    }
}
