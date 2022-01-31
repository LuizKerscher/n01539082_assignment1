using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_w2022_assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //Question 3
        public string Post()
        {
            return "Hello World!";
        }

        //Question 4
        public string Get(string id)
        {
            return "Greetings to " + id + " People!";
        }
    }
}
