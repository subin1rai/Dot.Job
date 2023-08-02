using JobPortal.Interface;
using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class ChangesController : Controller
    {
        private readonly IjobInterface _jobInterface;
        public ChangesController(IjobInterface jobInterface)
        {
            _jobInterface = jobInterface;
        }

        [HttpGet]
        public IActionResult ListJob()
        {
            var allJob = _jobInterface.GetJobTitles();
            return View(allJob);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddJob(JobTitle jobTitle)
        {
            _jobInterface.AddJob(jobTitle);
            return RedirectToAction("ListJob");
        }
        
        //[HttpGet]
        //public IActionResult Details(Guid jobID)
        //{
        //    var JobDetails = _jobInterface.GetByID(jobID);
        //    return View(JobDetails);
        //}

        [HttpGet]
        public IActionResult EditJob(Guid Id)
        {
            var editjob = _jobInterface.GetByID(Id);
            return View(editjob);
        }
        [HttpPost]
        public IActionResult EditJob(JobTitle jobTitle)
        {
            _jobInterface.EditJob(jobTitle);
            return RedirectToAction("ListJob");
        }
        [HttpGet]
        public IActionResult DeleteJob(Guid Id)
        {
            var deletejob = _jobInterface.GetByID(Id);
            return View(deletejob);
        }
        [HttpPost]
        public IActionResult DeleteJob(JobTitle jobTitle)
        {
            _jobInterface.DeleteJob(jobTitle);
            return RedirectToAction("ListJob");
        }
    }
}
