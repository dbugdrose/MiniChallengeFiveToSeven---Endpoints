using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCFiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCFiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCSixController : ControllerBase
    {
        private readonly MCSixServices _mcSixServices;
        
        public MCSixController(MCSixServices mcSixServices)
        {
            _mcSixServices = mcSixServices;
        }

        [HttpGet]
        [Route("OddOrEven/{num1}")]
        
        public string OddOrEven(int num1)
        {
            return _mcSixServices.OddOrEven(num1);
        }
    }
}