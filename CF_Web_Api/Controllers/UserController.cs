<<<<<<< HEAD
﻿using CF_Web_Api.Interface;
using CF_Web_Api.Repository;
=======
﻿using CF_Web_Api.Repository;
>>>>>>> 60ecb38452a540eb3b866d67bc8f73caee70ae99
using CF_Web_Api.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IUserRepository accountRepo;

        public UserController(IUserRepository repo)
=======
        private readonly IAccountRepository accountRepo;

        public UserController(IAccountRepository repo)
>>>>>>> 60ecb38452a540eb3b866d67bc8f73caee70ae99
        {
            accountRepo = repo;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(Register signUpModel)
        {
            var result = await accountRepo.SignUpAsync(signUpModel);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }

            return Unauthorized();
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(Login signInModel)
        {
            var result = await accountRepo.SignInAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(result);
        }
    }
}
