using Microsoft.AspNetCore.Mvc;
using System;

namespace NoelExpenseTracker.Controllers
{
    public class AppointmentController : Controller
    {
          public IActionResult Index(int id)
          {
               return View();
               //return Ok("Action Details called with id " + id);

          }

          public IActionResult aa() 
          {
               return Content("<h3>Zain Ul Hassan</h3>", "text/html");
          }

          public IActionResult Okk()
          {
               return Ok("Ok Ok Ok");
          }


     }
}
