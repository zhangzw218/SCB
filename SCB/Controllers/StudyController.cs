using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCB.Controllers
{
    public class StudyController : Controller
    {
        // GET: Study
        public ActionResult Index()
        {
            return Html();
        }
        // GET: Study
        public ActionResult Html()
        {
            return View();
        }
        // GET: Study
        public ActionResult Css()
        {
            return View();
        }
        // GET: Study
        public ActionResult JavaScrpts()
        {
            return View();
        }
    }
}