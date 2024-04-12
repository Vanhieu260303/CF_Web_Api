using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportAuthorizesController : ControllerBase
    {
        private readonly IReportAuthorizesRepository _reportAuthorizeRepository;
        private readonly IMapper _mapper;
        public ReportAuthorizesController(IReportAuthorizesRepository reportAuthorizeRepository, IMapper mapper)
        {
            _reportAuthorizeRepository = reportAuthorizeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllReportAuthorize()
        {
            var fDanhGia = _mapper.Map<List<ReportAuthorizesDto>>(_reportAuthorizeRepository.GetReportAuthorizes());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(fDanhGia);

        }
        [HttpGet("{Id}")]
        public IActionResult GetReportAuthorizeId(Guid Id)
        {
            if (!_reportAuthorizeRepository.ReportAuthorizeExits(Id))
                return BadRequest();

            var rAuth = _mapper.Map<ReportAuthorizesDto>(_reportAuthorizeRepository.GetReportAuthorize(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(rAuth);
        }
    }
}
