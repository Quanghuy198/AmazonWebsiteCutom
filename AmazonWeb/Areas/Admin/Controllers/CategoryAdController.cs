using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonWeb.EF;
using AmazonWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonWeb.Areas.Admin.Controllers
{
    public class CategoryAdController : Controller
    {
        private  EDbContext _context = new EDbContext();
        // GET: /<controller>/
        
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/Admin/CategoryAd/Create")]
        public async Task<IActionResult> Create()
        {
            // ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug");
            var listcategory = await _context.categories.ToListAsync();
            listcategory.Insert(0, new Category()
            {
                Id = -1,
                SeoTitle = "Not Exits Parent Id"
            });
            
            ViewBag.ParentId = new SelectList(listcategory, "Id", "SeoTitle");

            var listlanguage = await _context.languages.ToListAsync();
            ViewBag.LanguageId = new SelectList(listlanguage, "Id", "Name");
            return View();
        }

        [HttpPost("/Admin/CategoryAd/Create")]
        public async Task<IActionResult> Create([Bind("Id,ParentId,SortOrder,IsShowOnHome,Status" +
            "Name","SeoDescription", "SeoTitle", "SeoAlias", "LanguageId")] Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.ParentId.Value == -1)
                    category.ParentId = null;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug", category.ParentId);
            var listcategory = await _context.categories.ToListAsync();
            listcategory.Insert(0, new Category()
            {
                Id = -1
            });
            ViewData["ParentId"] = new SelectList(listcategory, "Id", category.ParentId.ToString());
            return View(category);
        }
    }
}
