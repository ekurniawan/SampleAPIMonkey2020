using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBackendAPI.Models;

namespace MyBackendAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonkeyController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Monkey> Get()
        {
            return MonkeyData.Monkeys.ToList<Monkey>();
        }
    }
}
