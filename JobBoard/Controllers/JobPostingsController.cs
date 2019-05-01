using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobPostingsController : Controller
  {
      [HttpGet("/jobpostings")]
      public ActionResult Index() 
      {
        List<JobPosting> allJobPostings = JobPosting.GetAll();
        return View(allJobPostings);
      }

      [HttpPost("/jobpostings")]
      public ActionResult Create(string jobtitle, string description, string contactinfo)
      {
          JobPosting newJobPosting = new JobPosting(jobtitle, description, contactinfo);
          return RedirectToAction("Index");
      }

      [HttpGet("/jobpostings/new")]
      public ActionResult Form()
      {
          return View();
      }
  }
}