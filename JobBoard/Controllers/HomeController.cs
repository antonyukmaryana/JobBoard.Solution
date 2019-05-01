using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index() 
    {
      JobPosting newJobPosting = new JobPosting("job title", "description", "contactinfo");
      return View(newJobPosting); 
    }
  }
}
