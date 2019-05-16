using Microsoft.AspNetCore.Mvc;
using Blackj.Models;

namespace Blackj.Controllers
{
  public class Homecontroller : Controller
  {
    [HttpGet("/")]
    public ActionResult Home()
    {
      Counter newCounter = new Counter(0, 0, 0);
      return View(newCounter);
    }

    [HttpGet("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/score")]
    public ActionResult Score(string one)
    {
      Counter newCounter = new Counter(0, 0, 0);
      newCounter.AddRunningTotal(int.Parse(one));
      return View("Home", newCounter);
    }
  }
}
