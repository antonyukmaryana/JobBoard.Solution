
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index() 
    {
      return View();
      // List<JobPosting> allJobPostings = JobPosting.GetAll();
      // return View(allJobPostings);
    }
  }
}
