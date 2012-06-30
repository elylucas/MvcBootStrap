using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBootStrap.Web.Infrastructure
{
    public class StupidLittleService : IStupidLittleService
    {
        public string GetSomethingStupid(){
            return "duh";
        }

        public string GetSomethingSmart()
        {
            return "brilliant!";
        }
    }
}