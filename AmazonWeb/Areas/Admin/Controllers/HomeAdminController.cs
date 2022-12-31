using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonWeb.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        [HttpGet("/Admin/HomeAdmin/")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Admin/HomeAdmin/CreateProduct")]
        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}


