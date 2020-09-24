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
        /// <summary>
        /// This method returns 10 more than the integer input {id} when receiving a get request
        /// <example>GET api/addten/{id}</example>
        /// </summary>
        /// <param name="id">Integer</param>
        /// <returns>id+10</returns>
        public int Get(int id)
        {
            int tenMore = id + 10;
            return tenMore;
        }
    }
}
