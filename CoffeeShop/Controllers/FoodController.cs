using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeShop.Controllers
{
    [ApiController]
    //request comes in at api/weatherforecast
    [Route("api/[controller]")]
    public class FooController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FooController> _logger;

        public FooController(ILogger<FooController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new List<string> { "foo", "bar" };
            
        }

        [HttpGet("{id}")]

        public IEnumerable<string> GetOne()
        {
            return new List<string> { "this", "is", "two" };
        }

        [HttpPost]

        public IEnumerable<string> Post()
        {
            return new List<string> { "this", "is", "get" };
        }
    }
}
