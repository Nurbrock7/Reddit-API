using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reddit_API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit_API.Controllers
{
    public class HomeController : Controller
    {   
        private DbContext db = new DbContext();
        public IActionResult Index()
        {
            return View(db.Topics.ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Topic topic)
        {
            if (!ModelState.IsValid)
            {
                db.Topics.Add(topic);
                db.SaveChanges();
                return RedirectToAction();
            }
            return View(topic);

        }
    }
}
