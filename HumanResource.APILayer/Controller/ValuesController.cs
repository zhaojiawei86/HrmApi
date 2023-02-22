using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanResource.APILayer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // ok, content, notfound
            return Ok("This is working successfully");
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult Get(string name)
        {
            return Ok(new { Id=1, Name=name, Age=30, City="London"});
        }
    }
}

