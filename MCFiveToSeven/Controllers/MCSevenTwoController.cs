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
    public class MCSevenTwoController : ControllerBase
    {
        private readonly MCSevenTwoServices _mcSevenTwoServices;
        public MCSevenTwoController(MCSevenTwoServices mcSevenTwoServices)
        {
            _mcSevenTwoServices = mcSevenTwoServices;
        }

        [HttpGet]
        [Route("ReverseItNumeric/{numbers}")]
        
        public string ReverseItNumeric(int numbers)
        {
            return _mcSevenTwoServices.ReverseItNumeric(numbers);
        }
    }
}