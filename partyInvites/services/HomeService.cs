﻿using System;
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
            
                homeService = new HomeService(modelState);
            
            return homeService;
        }

        public bool handleForm(GuestResponse guestResponse)
        {
           
            if (!_modelState.IsValid)
            {
                return false;
            }

            return true;

            //todo: you can now handle the saving and bussiness logic and move on based on that  
           
        }
           

    }
}