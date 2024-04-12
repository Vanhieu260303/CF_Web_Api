using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly IMapper _mapper;
        public RoomsController(IRoomsRepository roomsRepository, IMapper mapper)
        {
            _roomsRepository = roomsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            var rDG = _mapper.Map<List<RoomsDto>>(_roomsRepository.GetRooms());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(rDG);

        }
        [HttpGet("{Id}")]
        public IActionResult GetRoomById(Guid Id)
        {
            if (!_roomsRepository.RoomsExist(Id))
                return BadRequest();

            var room = _mapper.Map<RoomsDto>(_roomsRepository.GetRoom(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(room);
        }
    }
}
