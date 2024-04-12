using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportDanhGiasController : ControllerBase
    {
        private readonly IReportDanhGiaRepository _reportDanhGiaRepository;
        private readonly IMapper _mapper;
        public ReportDanhGiasController(IReportDanhGiaRepository reportDanhGiaRepository, IMapper mapper)
        {
            _reportDanhGiaRepository = reportDanhGiaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllReportDG()
        {
            var rDG = _mapper.Map<List<ReportDanhGiaDto>>(_reportDanhGiaRepository.GetReportDanhGias());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(rDG);

        }
        [HttpGet("{Id}")]
        public IActionResult GetReportDGById(Guid Id)
        {
            if (!_reportDanhGiaRepository.ReportDanhGiaExits(Id))
                return BadRequest();

            var rDG = _mapper.Map<ReportDanhGiaDto>(_reportDanhGiaRepository.GetReportDanhGia(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(rDG);
        }
    }
}
