using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the integer input {id} when receiving a get request
        /// <example>GET api/square/{id}</example>
        /// </summary>
        /// <param name="id">Integer</param>
        /// <returns>id*id</returns>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
