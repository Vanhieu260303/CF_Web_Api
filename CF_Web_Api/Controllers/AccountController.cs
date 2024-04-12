using AutoMapper;
using CF_Web_Api.Dto;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AccountController(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAccount()
        {
            var account = _mapper.Map<List<AccountDto>>(_accountRepository.GetAccounts());
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(account);

        }
        [HttpGet("{Id}")]
        public IActionResult GetAccountById(Guid Id)
        {
            if (!_accountRepository.AccountsExits(Id))
                return BadRequest();

            var account = _mapper.Map<AccountDto>(_accountRepository.GetAccount(Id));
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(account);
        }
    }
}
