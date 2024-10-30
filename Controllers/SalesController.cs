using MarketDemo.Entities;
using MarketDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketDemo.Controllers
{
    public class SalesController : Controller
    {
		private readonly SaleRep rep;

		public SalesController(SaleRep rep)
        {
			this.rep = rep;
		}
        public IActionResult Index()
        {
            
            ViewData["Saleo"] = rep.GetAll();
            return View();
        }
    }
}
