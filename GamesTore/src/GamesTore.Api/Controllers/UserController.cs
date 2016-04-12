using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Repository.Repositories;
using Microsoft.AspNet.Mvc;
using System.Net.Http;
using GamesTore.Domain.DTOs;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GamesTore.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        
        // GET: api/values
        [HttpGet]
        public async Task< IActionResult> Get()
        {
            UserRepository repo = new UserRepository();
            var temp = await repo.GetAllUsers();
            return Ok(temp);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            UserRepository repo = new UserRepository();
            var temp = await repo.GetUserById(id);
            return Ok(temp);
        }

        // POST api/values
        [HttpPost]
        public  IActionResult Post([FromBody]UserDTO user)
        {
            UserRepository repo = new UserRepository();
            repo.AddUser(user);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]UserDTO user)
        {
            UserRepository repo = new UserRepository();
            return Ok(await repo.EditUser(user));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserRepository repo = new UserRepository();
            repo.DeleteUser(id);
            return Ok();
        }
    }
}
