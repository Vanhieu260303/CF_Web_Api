using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorsController : ControllerBase
    {

        private readonly IFloorsRepository _floorsRepository;
        private readonly IMapper _mapper;
        public FloorsController(IFloorsRepository floorsRepository, IMapper mapper)
        {
            _floorsRepository = floorsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllFloors()
        {
            var Floors = _mapper.Map<List<FloorsDto>>(_floorsRepository.GetFloors());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(Floors);

        }
        [HttpGet("{Id}")]
        public IActionResult GetFloorsById(Guid Id)
        {
            if (!_floorsRepository.FloorsExits(Id))
                return BadRequest();

            var floors = _mapper.Map<FloorsDto>(_floorsRepository.GetFloor(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(floors);
        }





    }
}
