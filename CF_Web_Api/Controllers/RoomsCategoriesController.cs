using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsCategoriesController : ControllerBase
    {
        private readonly IRoomCategoryRepository _roomCategoryRepository;
        private readonly IMapper _mapper;
        public RoomsCategoriesController(IRoomCategoryRepository roomCategoryRepository, IMapper mapper)
        {
            _roomCategoryRepository = roomCategoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRoomsCate()
        {
            var roomcate = _mapper.Map<List<RoomsCategoryDto>>(_roomCategoryRepository.GetCategories());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(roomcate);

        }
        [HttpGet("{Id}")]
        public IActionResult GetRoomCateById(Guid Id)
        {
            if (!_roomCategoryRepository.RoomCategoryExits(Id))
                return BadRequest();

            var roomcate = _mapper.Map<RoomsCategoryDto>(_roomCategoryRepository.GetCategory(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(roomcate);
        }
    }
}
