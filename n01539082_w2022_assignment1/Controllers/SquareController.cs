using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01539082_w2022_assignment1.Controllers
{
    public class SquareController : ApiController
    {
       //Question 2
        public int Get(int id)
        {
            return id * id;
        }
    }
}
