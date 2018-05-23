using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_.Net_Core.Models;

namespace Web_Api_.Net_Core.Controllers
{

    [Route("api/user")]
    public class UserController : Controller
    {
        //[HttpGet]
        //public string Get()
        //{
        //    return "asasas";
        //}

        //[HttpGet("{searchstring}")]
        //public IActionResult Get(string searchstring)
        //{
        //    return new ObjectResult(searchstring);
        //}


        //[HttpGet("{Id:int}")]
        //public IActionResult Get(int Id)
        //{
        //    return new ObjectResult(Id);
        //}
        [HttpPost]
        public IActionResult Insert([FromBody]UserModel user)
        {
            if(user==null)
            {
                return BadRequest("Recieved a Bad request");
            }
            
        }
    }
}
