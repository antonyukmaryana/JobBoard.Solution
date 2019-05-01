using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobPostingsController : Controller
  {
      [HttpPost("/jobpostings")]
      public ActionResult Create(string jobtitle, string description, string contactinfo)
      {
          JobPosting newJobPosting = new JobPosting("job title", "description", "contactinfo");
          return View("Index", newJobPosting);
      }

      [HttpGet("/jobpostings/new")]
      public ActionResult Form()
      {
          return View();
      }
  }
}