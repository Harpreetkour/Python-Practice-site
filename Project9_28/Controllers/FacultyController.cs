using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project9_28.Models;

namespace Project9_28.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
      

        [HttpGet]
        public ActionResult AddNewClass()
        {
            Course cs = new Course();
            return View(cs);
        }

        [HttpPost]
        public ActionResult AddNewClass(FormCollection form)
        {
            var name=form[0];
            return View();
        }
        [HttpGet]
        public ActionResult AddNewQuestion()
        {
            Question qn = new Question();
            return View(qn);
        }

        [HttpPost]
        public ActionResult AddNewQuestion(FormCollection form)
        {
         //   Question qn = new Question();
            return View();
        }

        [HttpGet]
        public ActionResult PersonalInformation()
        {
            Professor pf = new Professor();
            return View(pf);
        }
        [HttpPost]
        public ActionResult PersonalInformation(FormCollection form)
        {
            //Professor pf = new Professor();
            return View();
        }
    }
}