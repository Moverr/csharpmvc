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
            homeService = HomeService.getInstance(this.ModelState);
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
            bool result = homeService.handleForm(guestResponse);

            if (result == false)
            {
                return View();

            }
            else
            {
                return View("Thanks", guestResponse);
            }
               


        }


    }
}