using Microsoft.AspNetCore.Mvc;

namespace Registry.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}