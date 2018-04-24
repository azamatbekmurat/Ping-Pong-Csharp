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

        [HttpPost("ping-pong")]
        public ActionResult Check()
        {
          int inputNumber = int.Parse(Request.Form["input-number"]);
          PingPongGenerator range = new PingPongGenerator(inputNumber);
          range.ToReplace();
          List<PingPongGenerator> AllNumbers = PingPongGenerator.GetAll();
          return View("Result", AllNumbers);
        }

  }
}
