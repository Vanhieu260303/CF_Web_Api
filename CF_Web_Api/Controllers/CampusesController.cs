using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusesController : ControllerBase
    {
        private readonly ICampusRepository _campusRepository;
        private readonly IMapper _mapper;
        public CampusesController(ICampusRepository campusRepository, IMapper mapper)
        {
            _campusRepository = campusRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCampus()
        {
            var campus = _mapper.Map<List<CampusDto>>(_campusRepository.GetCampuses());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(campus);

        }
        [HttpGet("{Id}")]
        public IActionResult GetCampusById(Guid Id)
        {
            if (!_campusRepository.CampusExits(Id))
                return BadRequest();

            var campus = _mapper.Map<CampusDto>(_campusRepository.GetCampus(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(campus);
        }
    }
}
