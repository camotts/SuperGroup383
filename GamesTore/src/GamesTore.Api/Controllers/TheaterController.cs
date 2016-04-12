using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesTore.Domain.DTOs;
using GamesTore.Repository.Repositories;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GamesTore.Api.Controllers
{
    [Route("api/[controller]")]
    public class TheaterController : Controller
    {
        private const string RoomEndpoint = "Room";
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            TheaterRepository repo = new TheaterRepository();
            var temp = await repo.GetAllTheaters();
            return Ok(temp);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TheaterRepository repo = new TheaterRepository();
            var temp = await repo.GetTheaterById(id);
            return Ok(temp);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //Get api/values/5/***
        [HttpGet(RoomEndpoint)]
        public void GetRooms()
        {
            
        }

        [HttpPost(RoomEndpoint)]
        public IActionResult PostRoom([FromBody] TheaterRoomDTO theaterRoom)
        {
            TheaterRoomRepository repo = new TheaterRoomRepository();
            repo.AddTheaterRoom(theaterRoom);
            return Ok();
        }
    }
}
