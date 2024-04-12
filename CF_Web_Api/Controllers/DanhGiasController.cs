using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhGiasController : ControllerBase
    {
        private readonly IDanhGiaRepository _danhGiaRepository;
        private readonly IMapper _mapper;
        public DanhGiasController(IDanhGiaRepository danhGiaRepository, IMapper mapper)
        {
            _danhGiaRepository = danhGiaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllDanhGias()
        {
            var danhgia = _mapper.Map<List<DanhGiaDto>>(_danhGiaRepository.GetDanhGias());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(danhgia);

        }
        [HttpGet("{Id}")]
        public IActionResult GetDanhGiaById(Guid Id)
        {
            if (!_danhGiaRepository.DanhGiaExits(Id))
                return BadRequest();

            var danhgia = _mapper.Map<DanhGiaDto>(_danhGiaRepository.GetDanhGia(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(danhgia);
        }
    }
}
