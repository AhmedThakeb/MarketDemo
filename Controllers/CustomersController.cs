using MarketDemo.Entities;
using MarketDemo.Models;
using MarketDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketDemo.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerRep rep;

        public CustomersController(CustomerRep rep)
        {
            this.rep = rep;
        }
        public IActionResult Index()
        {
           
            ViewData["Custo"] = rep.GetAll();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomersVM Obj)
        {
            Customers customers = new Customers();
            customers.Name = Obj.Name;
            rep.AddObj(customers);
            return Redirect("/customers/index");

        }
    }
}