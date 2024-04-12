using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasController : ControllerBase
    {
        private readonly ICasRepository _casRepository;
        private readonly IMapper _mapper;
        public CasController(ICasRepository casRepository, IMapper mapper)
        {
            _casRepository = casRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCas()
        {
            var cas = _mapper.Map<List<CasDto>>(_casRepository.GetCas());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(cas);

        }
        [HttpGet("{Id}")]
        public IActionResult GetCasById(Guid Id)
        {
            if (!_casRepository.CasExits(Id))
                return BadRequest();

            var cas = _mapper.Map<CasDto>(_casRepository.GetCa(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(cas);
        }



    }
}
