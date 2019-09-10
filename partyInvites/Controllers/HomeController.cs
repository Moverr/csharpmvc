﻿using partyInvites.Models;
using System;
using System.Web.Mvc;
using partyInvites.services;

namespace partyInvites.Controllers
{
    public class HomeController : Controller
    {
          HomeService homeService;
        /*public ActionResult Index()
        {
            return View();
        }
        */

            public HomeController()
        {
            homeService = HomeService.getInstance();
        }
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
           
            if(ModelState.IsValid)
            {
                homeService.handleForm(guestResponse);

                ViewBag.Message = "Your RSV Form.";
                return View("Thanks", guestResponse);
            }
            ViewBag.Message = "Something is Wrong.";
            return View();

        }


    }
}