using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_w2022_assignment1.Controllers
{
    public class HostCostController : ApiController
    {
        //Question 6
        public string Get(int id)
        {
            int fnDivRest = id % 14;
            double fnDiv = id / 14;
            int fn = (int)fnDiv;

            if (fnDivRest != 0)
            {
                fn = fn + 1;
            }

            double cost = fn * 5.5;
            double hst = (fn * 5.5) * 1.13;
            return fn + " fortnights at $5.50/FN = $" + cost + " CAD \nHST 13% = $" + hst + " CAD \nTotal = $" + cost+hst + " CAD";
            
        }
    }
}
