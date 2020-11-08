using BettingTrivia.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BettingTrivia.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var room = _roomService.GetRoom(id);
            if (room == null)
                return NotFound();
            return Ok(room);
        }

        [HttpPost]
        public IActionResult Post()
        {
            var newRoom = _roomService.CreateRoom();
            return Ok(newRoom);
        }
    }
}