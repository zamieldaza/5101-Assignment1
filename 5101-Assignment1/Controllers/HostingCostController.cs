using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        // Input : Integer
        // Output : Integer input divided by 14
        public int Get(int id)
        {
            int dividedby14 = id/14;
            return dividedby14;
        }
    }
}
