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
        /// <summary>
        /// This method returns a string when receiving a post request
        /// <example>POST api/greeting</example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        /// <summary>
        /// This method returns a string combined with an integer input {id} when receiving a post request
        /// <example>GET api/greeting/{id}</example>
        /// </summary>
        /// <param name="id">Integer</param>
        /// <returns>"Greetings to id people!"</returns>
        public string Get(int id)
        {
            string greeting = "Greetings to " + id + " people!";
            return greeting;
        }
    }
}
