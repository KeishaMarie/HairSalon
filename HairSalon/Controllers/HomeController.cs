using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : HomeController
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}