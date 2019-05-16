using Microsoft.AspNetCore.Mvc;
using Blackj.Models;

namespace Blackj.Controllers
{
  public class Homecontroller : Controller
  {
    [Route("/")]
    public ActionResult Home()
    {
      Counter newCounter = new Counter(0, 0, 0);
      return View(newCounter);
    }
  }
}