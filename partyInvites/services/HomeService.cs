using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using partyInvites.Models;

namespace partyInvites.services
{
    public class HomeService
    {
        private static HomeService homeService;
        private ModelStateDictionary _modelState;


        public HomeService()
        {

        }

        public static HomeService getInstance()
        {
            if(homeService == null)
            {
                homeService = new HomeService();
            }
            return homeService;
        }

        public bool handleForm(GuestResponse guestResponse)
        {
            _modelState.AddModelError("General", "Testing General Error");
            if (_modelState.IsValid)
            {
                return true;
            }

            return false;
        }
           

    }
}