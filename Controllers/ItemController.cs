using Microsoft.AspNetCore.Mvc;
using NoelExpenseTracker.Data;
using NoelExpenseTracker.Models;
using System.Collections;
using System.Collections.Generic;

namespace NoelExpenseTracker.Controllers
{
    public class ItemController : Controller
    {
          private readonly ApplicationDbContext _db;

          public ItemController(ApplicationDbContext db)
          {
               _db = db;
          }

          public IActionResult Index()
          {
               IEnumerable<Item> objList = _db.Items;
               return View(objList);  
          }

          //GET-Create
          public IActionResult Create()
          {
               return View();
          }

          //POST-Create
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
