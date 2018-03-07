using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_Practice.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "This is Index action method of StudentController";
        }
    }
}