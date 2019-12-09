using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using WebApplication3.Helpers;
using WebApplication3.ServiceReference1;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
       
        public string Get()
        {
            ZRemotListsample zls = new ZRemotListsample();
            ZRemotListsampleResponse loadResponse = new ZRemotListsampleResponse();

            try
            {
                ZRemotListsampleRequest zr = new ZRemotListsampleRequest();
                zr.ZRemotListsample = zls;
                
               
                loadResponse = SapConnector.Client().ZRemotListsample(zr.ZRemotListsample);
               
             
                return JsonConvert.SerializeObject(loadResponse);

            }
            catch (Exception e)
            {

            }
            return JsonConvert.SerializeObject(loadResponse);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
