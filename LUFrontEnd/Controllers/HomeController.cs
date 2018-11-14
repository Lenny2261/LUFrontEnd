using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LUFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.DegreeType = new List<SelectListItem>(){
                new SelectListItem() { Text = "Select", Value = "Select" },
                new SelectListItem() { Text = "Lorem", Value = "Lorem" },
                new SelectListItem() { Text = "Ipsum", Value = "Ipsum" },
                new SelectListItem() { Text = "Dolor", Value = "Dolor" },
                new SelectListItem() { Text = "Sit", Value = "Sit" },
                new SelectListItem() { Text = "Amet", Value = "Amet" }
            };
            ViewBag.StudyType = new List<SelectListItem>(){
                new SelectListItem() { Text = "Select a degree type", Value = "Select a degree type" },
                new SelectListItem() { Text = "Lorem", Value = "Lorem" },
                new SelectListItem() { Text = "Ipsum", Value = "Ipsum" },
                new SelectListItem() { Text = "Dolor", Value = "Dolor" },
                new SelectListItem() { Text = "Sit", Value = "Sit" },
                new SelectListItem() { Text = "Amet", Value = "Amet" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}