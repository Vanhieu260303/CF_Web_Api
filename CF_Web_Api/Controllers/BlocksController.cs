using AutoMapper;
using CF_Web_Api.Data;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using CF_Web_Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocksController : ControllerBase
    {
        private readonly IBlocksRepository _blocksRepository;
        private readonly IMapper _mapper;
        public BlocksController(IBlocksRepository blockRepository,IMapper mapper) 
        {
            _blocksRepository = blockRepository;
           _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllBlocks() 
        {
            var blocks = _mapper.Map<List<BlocksDto>>(_blocksRepository.GetBlocks());
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }   
            return Ok(blocks);

        }
        [HttpGet("{Id}")]
        public IActionResult GetBlockById(Guid Id)
        {
            if (!_blocksRepository.BlocksExits(Id))
                return BadRequest();

            var blocks = _mapper.Map<BlocksDto>( _blocksRepository.GetBlock(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(blocks);
        }

      
    }
}
