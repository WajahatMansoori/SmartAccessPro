using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityQuestionPaperManagment.AuthMiddleWare;

namespace UniversityQuestionPaperManagment.Controllers
{
    public class ModeratorController : Controller
    {
        // GET: Moderator
        [CustomAuthorize(UserRole = "Moderator")]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}