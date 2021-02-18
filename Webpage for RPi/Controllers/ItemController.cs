using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webpage_for_RPi.Data;
using Webpage_for_RPi.Models;

namespace Webpage_for_RPi.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
        
        public IActionResult Create()
        {
            
            return View();
        }
        
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}