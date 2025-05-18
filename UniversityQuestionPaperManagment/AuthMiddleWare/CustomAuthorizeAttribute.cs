using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityQuestionPaperManagment.AuthMiddleWare
{
    public class CustomAuthorizeAttribute: AuthorizeAttribute
    {
        public string UserRole { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var role = httpContext.Session["Role"] as string;
            return !string.IsNullOrEmpty(role) && role == UserRole;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/Auth/Login");
        }
    }
}