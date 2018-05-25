using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_.Net_Core.Models;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult Insert([FromBody] UserModel user)
        {
            try
            {

                if (user.FirstName != null)
                {
                    UserItems.Add(user);
                }
              
               
               return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e);
            }
           
        }
        [HttpGet]
        public  IList<UserModel> GetAll()
        {
            var item =  UserItems.GetAll();
            if (item == null)
            {
                
            }
            return  item;
        }
        [HttpGet("{id}")]
        public  IActionResult GetById(string id)
        {
            var item = UserItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
