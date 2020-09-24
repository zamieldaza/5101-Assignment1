using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        // Input : Integer
        // Output : 10 more than the integer input
        public int Get(int id)
        {
            int tenMore = id + 10;
            return tenMore;
        }
    }
}
