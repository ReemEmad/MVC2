using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
     

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Contact(Employee emp)
        {
            var ctx = new ModelContext();
            if (ModelState.IsValid)
            {
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
                return View("About",emp);

            }
            return View();
        }
    }
}