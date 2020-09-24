using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // Output : "Hello World!"
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        // Input : Integer id
        // Output : "Greetings to id people!"
        public string Get(int id)
        {
            string greeting = "Greetings to " + id + " people!";
            return greeting;
        }
    }
}
