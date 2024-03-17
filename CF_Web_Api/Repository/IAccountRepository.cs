using CF_Web_Api.Service;
using Microsoft.AspNetCore.Identity;

namespace CF_Web_Api.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(Register model);
        public Task<string> SignInAsync(Login model);
    }
}
