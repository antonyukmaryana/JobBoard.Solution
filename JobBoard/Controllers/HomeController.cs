using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() 
    {
      JobPosting newJobPosting = new JobPosting("job title", "description", "contactinfo");
      return View(newJobPosting); 
    }
  }
}
