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


        public HomeService(ModelStateDictionary modelState)
        {
            _modelState = modelState;
        }

        public static HomeService getInstance(ModelStateDictionary modelState)
        {
            if(homeService == null)
            {
                homeService = new HomeService(modelState);
            }
            return homeService;
        }

        public bool handleForm(GuestResponse guestResponse)
        {
            // _modelState.AddModelError("General", "Testing General Error");
            if (_modelState.IsValid)
            {
                return false;
            }
            return true;
        }
           

    }
}