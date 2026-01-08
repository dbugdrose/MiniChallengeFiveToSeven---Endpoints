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
    public class MCSevenOneController : ControllerBase
    {
private readonly MCSevenOneServices _mcSevenOneServices;

        public MCSevenOneController(MCSevenOneServices mcSevenOneServices)
        {
            _mcSevenOneServices = mcSevenOneServices;
        }

        [HttpGet]
        [Route("ReverseItAlphanumeric/{LettersAndNumbers}")]
        
        public string ReverseItAlphanumeric(string LettersAndNumbers)
        {
            return _mcSevenOneServices.ReverseItAlphanumeric(LettersAndNumbers);
        }
    }
}