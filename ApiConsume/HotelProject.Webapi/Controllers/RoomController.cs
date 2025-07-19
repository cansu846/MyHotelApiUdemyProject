using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = roomService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult RoomDetail(int id) {
            var values = roomService.TGetByID(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateRoom(Room room)
        {
            roomService.TInsert(room);

            return Ok("Room added");
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room) {
            var values = roomService.TGetByID(room.RoomID);
            values.RoomNumber = room.RoomNumber;
            values.RoomCoverImage = room.RoomCoverImage;
            values.Price  = room.Price; 
            values.Title = room.Title;
            values.BathCount = room.BathCount;  
            values.BedCount = room.BedCount;    
            roomService.TUpdate(values);
            return Ok("Room successfully updated");    
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id) {
            var values = roomService.TGetByID(id);
            roomService.TDelete(values);
        return Ok();
        }
    }
}
