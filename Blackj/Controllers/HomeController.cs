using Microsoft.AspNetCore.Mvc;
using Blackj.Models;

namespace Blackj.Controllers
{
  public class Homecontroller : Controller
  {
    [HttpGet("/")]
    public ActionResult Home()
    {
      Counter newCounter = new Counter();
      return View(newCounter);
    }

    [HttpGet("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Score(string one)
    {
      Counter newCounter = new Counter();
      newCounter.AddRunningTotal(int.Parse(one));
      return View("Home", newCounter);
    }
  }
}
