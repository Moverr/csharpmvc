using partyInvites.Models;
using System;
using System.Web.Mvc;

namespace partyInvites.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            return View();
        }
        */
        public ViewResult index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon" ;
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

        [HttpGet]
        public ActionResult RsvForm()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpPost]
        public ActionResult RsvForm(GuestResponse guestResponse)
        {
           
            //todo: email response to the organiser
            ViewBag.Message = "Your RSV Form.";
            return View("Thanks", guestResponse);
        }


    }
}