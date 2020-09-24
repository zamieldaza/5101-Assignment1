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
        // Input : Integer
        // Output : Square of the integer input
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
