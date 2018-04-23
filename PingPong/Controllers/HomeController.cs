using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PingPong.Models;
using System;

namespace PingPong.Controllers
{
  public class HomeController : Controller
  {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpGet("ping-pong")]
        public ActionResult Check()
        {
          cLeapYear checkLeapYear = new cLeapYear(Int32.Parse(Request.Form["input-year"]));

          checkLeapYear.IsLeapYear();

          return View("Result");
        }


  }
}
