using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonWeb.Controllers
{
    public class LocationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new Location();
            model.Name = "CA";
            return View(model);
        }


    }
}
