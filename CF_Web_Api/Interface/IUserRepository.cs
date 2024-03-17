using CF_Web_Api.Service;
using Microsoft.AspNetCore.Identity;

namespace CF_Web_Api.Interface
{
    public interface IUserRepository
    {
        public Task<IdentityResult> SignUpAsync(Register model);
        public Task<string> SignInAsync(Login model);
    }
}