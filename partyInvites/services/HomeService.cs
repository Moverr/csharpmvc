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

        public GuestResponse handleForm(GuestResponse guestResponse)
        {
            if (_modelState.IsValid)
            {
                return guestResponse;
            }

            throw new Exception("Invalid Selection");
        }
           

    }
}