using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home() { return View(); }
  }
}
