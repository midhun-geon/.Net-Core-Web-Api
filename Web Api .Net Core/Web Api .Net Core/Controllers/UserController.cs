using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_.Net_Core.Models;

namespace Web_Api_.Net_Core.Controllers
{

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController(IUser userItems)
        {
            UserItems = userItems;
        }
        public IUser UserItems { get; set; }

        [HttpPost]
        public IActionResult Insert(UserModel user)
        {    
            try
            {

                if (user == null)
                {
                    return BadRequest("Recieved a Bad request");
                }
              UserItems.Add(user);
               
               return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
           
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Get", "Me" };
        }
    }
}
