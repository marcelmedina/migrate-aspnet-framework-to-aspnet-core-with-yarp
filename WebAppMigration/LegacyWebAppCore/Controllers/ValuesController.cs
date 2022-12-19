using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegacyWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "core1", "core2" };
        }
    }
}
