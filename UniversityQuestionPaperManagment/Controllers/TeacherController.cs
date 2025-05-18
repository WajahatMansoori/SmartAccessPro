using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityQuestionPaperManagment.AuthMiddleWare;

namespace UniversityQuestionPaperManagment.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        [CustomAuthorize(UserRole = "Teacher")]
        public ActionResult Dashboard()
        {
            return View();
        }

        [CustomAuthorize(UserRole = "Teacher")]
        public ActionResult CourseList()
        {
            return View();
        }

        [CustomAuthorize(UserRole = "Teacher")]
        public ActionResult GradingPaper()
        {
            return View();
        }

        [CustomAuthorize(UserRole = "Teacher")]
        public ActionResult PaperStatus()
        {
            return View();
        }
    }
}