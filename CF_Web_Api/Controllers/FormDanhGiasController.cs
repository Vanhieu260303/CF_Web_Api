using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormDanhGiasController : ControllerBase
    {
        private readonly IFormDanhGiaRepository _formDanhGiaRepository;
        private readonly IMapper _mapper;
        public FormDanhGiasController(IFormDanhGiaRepository formDanhGiaRepository, IMapper mapper)
        {
            _formDanhGiaRepository = formDanhGiaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllFormDG()
        {
            var fDanhGia = _mapper.Map<List<FormDanhGiasDto>>(_formDanhGiaRepository.GetFormDGs());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(fDanhGia);

        }
        [HttpGet("{Id}")]
        public IActionResult GetFormDGById(Guid Id)
        {
            if (!_formDanhGiaRepository.FormDanhGiaExits(Id))
                return BadRequest();

            var fDanhGia = _mapper.Map<FormDanhGiasDto>(_formDanhGiaRepository.GetFormDG(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(fDanhGia);
        }
    }
}
