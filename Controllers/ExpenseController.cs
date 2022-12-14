using Microsoft.AspNetCore.Mvc;
using NoelExpenseTracker.Data;
using NoelExpenseTracker.Models;
using System.Collections.Generic;

namespace NoelExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
          private readonly ApplicationDbContext _db;

          public ExpenseController(ApplicationDbContext db)
          {
               _db = db;
          }

          public IActionResult Index()
          {
               IEnumerable<Expense> objList = _db.Expenses;
               IEnumerable<Expense> filteredObjList;
               
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
          public IActionResult Create(Expense obj)
          {
               if (ModelState.IsValid)
               {
                    _db.Expenses.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               }
               return View(obj);
               
          }

          //GET-Delete
          public IActionResult Delete(int Id)
          {
               if (Id == null || Id==0)
               {
                    return NotFound();
               }
               var obj = _db.Expenses.Find(Id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);
               
          }

          //POST-Delete
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult PostDelete(int Id)
          {
               var obj = _db.Expenses.Find(Id);

               if(obj == null)
               {
                    return NotFound();
               }

               _db.Expenses.Remove(obj);
               _db.SaveChanges();
               return RedirectToAction("Index");
          }

          //GET-Update
          public IActionResult Update(int Id)
          {
               if (Id == null || Id == 0)
               {
                    return NotFound();
               }
               var obj = _db.Expenses.Find(Id);
               if (obj == null)
               {
                    return NotFound();
               }
               return View(obj);
          }

          //POST-Update
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Update(Expense obj)
          {
               if (ModelState.IsValid)
               {
                    //_db.Expenses.Add(obj);
                    _db.Expenses.Update(obj);

                    _db.SaveChanges();

                    return RedirectToAction("Index");
               }
               return View(obj);
               
          }
     }
}
