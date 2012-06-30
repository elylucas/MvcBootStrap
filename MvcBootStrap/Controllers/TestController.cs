using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBootStrap.Web.Infrastructure;

namespace MvcBootStrap.Web.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        IStupidLittleService stupidService;

        public TestController(IStupidLittleService stupidService)
        {
            this.stupidService = stupidService;
        }

        public string Index()
        {
            return stupidService.GetSomethingStupid();
        }

    }
}
