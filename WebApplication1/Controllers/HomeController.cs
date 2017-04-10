using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ActionResult response = Navigate() as ActionResult;
            return response;
        }

        public ActionResult Navigate()
        {
            bool response = false;
            if (response)
            {
                return RedirectToAction("Contact");
            }
            else
            {
                return RedirectToAction("About");
            }
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