using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partyInvites.services
{
    public class HomeService
    {
        private static HomeService homeService;
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

        public void handleForm( )
        {

        }

    }
}