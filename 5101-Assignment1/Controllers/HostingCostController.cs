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
        /// <summary>
        /// This method returns three strings that represent the web hosting cost of a number of days {id} when receiving a host request
        /// Rate $5.50/FN (fortnight = 14 days)
        /// Also charging harmonized sales tax (13% HST)
        /// <example>GET api/hostingcost/{id}</example>
        /// </summary>
        /// <param name="id">Integer - number of days</param>
        /// <returns>
        /// “{id} fortnights at $5.50/FN = subtotal”
        /// “HST 13% = subtotal*0.13”
        /// “Total = subtotal+tax”
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            // Number of fortnights
            int division = id/14;
            int fortnights = division + 1;
            // Subtotal
            double subtotal = Math.Round(fortnights*5.50,2);
            // Tax
            double tax = Math.Round(subtotal * 0.13, 2);
            // Total
            double total = Math.Round(subtotal + tax, 2);
            // String lines
            string line1 = division + " fortnights at $5,50/FN = $" + subtotal.ToString("0.00") + " CAD";
            string line2 = "HST 13% = $" + tax.ToString("0.00") + " CAD";
            string line3 = "Total = $" + total.ToString("0.00") + " CAD";
            // Final result
            return new string[] { line1, line2, line3};
        }
    }
}
