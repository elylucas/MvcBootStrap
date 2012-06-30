using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcBootStrap.Web.Infrastructure;

namespace MvcBootStrap.Web.Controllers
{
    public class Test2Controller : ApiController
    {
        private IStupidLittleService stupidLittleService;

        public Test2Controller(IStupidLittleService stupidLittleService)
        {
            this.stupidLittleService = stupidLittleService;
        }


        // GET api/<controller>
        public string Get()
        {
            return stupidLittleService.GetSomethingSmart();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}