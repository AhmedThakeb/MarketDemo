using MarketDemo.Entities;
using MarketDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketDemo.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            SaleRep rep = new SaleRep();
            ViewData["Saleo"] = rep.GetAll();
            return View();
        }
    }
}
