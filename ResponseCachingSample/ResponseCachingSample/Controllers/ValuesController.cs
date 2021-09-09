using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseCachingSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [ResponseCache(Duration = 30)]
        public IEnumerable<string> Get()
        {
            var time = "The response time is:" + DateTime.Now.ToString();
            return new string[] { "CachedItems", time };
        }


    }
}
