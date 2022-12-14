using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [HttpGet]
        [Route("room/all")]
        public IActionResult Get()
        {
            StudiesContext context = new StudiesContext();
            var rooms = (from x in context.Rooms
                         select x).ToList();

            return Ok(rooms);
        }

        [HttpGet]
        [Route("room/{id}")]
        public IActionResult GetSpec(int id)
        {
            StudiesContext context = new StudiesContext();
            var room = (from x in context.Rooms
                        where id == x.RoomSk
                        select x).FirstOrDefault();

            return Ok(room);
        }

        [HttpGet]
        [Route("instructor/{id}")]
        public IActionResult GetSpec2(int id)
        {
            StudiesContext context = new StudiesContext();
            var instructor = (from x in context.Instructors
                              where id == x.InstructorSk
                              select x).FirstOrDefault();

            return Ok(instructor);
        }

        [HttpPost]
        [Route("room/add")]
        public void Post([FromBody] Room room)
        {
            StudiesContext context = new StudiesContext();
            context.Rooms.Add(room);
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("room/del/{id}")]
        public void Delete(int id)
        {
            StudiesContext context = new StudiesContext();
            var törlendő = (from x in context.Rooms
                            where id == x.RoomSk
                            select x).FirstOrDefault();
            context.Remove(törlendő);
            context.SaveChanges();

        }
    }
}
