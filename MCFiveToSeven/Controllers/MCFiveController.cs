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
    public class MCFiveController : ControllerBase
    {
        private readonly MCFiveServices _mcFiveServices;

        public MCFiveController(MCFiveServices mcFiveServices)
        {
            _mcFiveServices = mcFiveServices;
        }

        [HttpGet]
        [Route("MadLib/{adjective}/{mythicalcreature}/{items}/{place}/{food}")]
        
        public string MadLib(string adjective, string mythicalcreature, string items, string place, string food)
        {
            return _mcFiveServices.MadLib(adjective, mythicalcreature, items, place, food);
        }
    }
}