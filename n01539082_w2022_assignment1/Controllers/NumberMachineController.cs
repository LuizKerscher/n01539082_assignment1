using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_w2022_assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Question 5
        public int Get(int id)
        {
            return id + 10 * 10 - 10 / 10;
        }
    }
}
