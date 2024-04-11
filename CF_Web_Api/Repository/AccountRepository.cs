using CF_Web_Api.Data;
<<<<<<< HEAD
using CF_Web_Api.Interface;
using System.Xml.Linq;
=======
using CF_Web_Api.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
>>>>>>> 60ecb38452a540eb3b866d67bc8f73caee70ae99

namespace CF_Web_Api.Repository
{
    public class AccountRepository : IAccountRepository
    {
<<<<<<< HEAD
        private readonly DataContext _dbcontext;
        public AccountRepository(DataContext dbcontext) 
        {
            _dbcontext = dbcontext;
        }

        public bool AccountsExits(Guid Id)
        {
            return _dbcontext.Accounts.Any(a => a.Id == Id);
        }

        public Account GetAccount(Guid Id)
        {
            return _dbcontext.Accounts.Where(a => a.Id == Id).FirstOrDefault();
        }

        public Account GetAccount(string Name)
        {
            return _dbcontext.Accounts.Where(a => a.UserName == Name).FirstOrDefault();
        }

        public ICollection<Account> GetAccounts()
        {
            return _dbcontext.Accounts.ToList();
=======
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;



        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }



        public async Task<string> SignInAsync(Login model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (!result.Succeeded)
            {
                return string.Empty;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(20),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha256Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<IdentityResult> SignUpAsync(Register model)
        {
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };

            return await userManager.CreateAsync(user, model.Password);
>>>>>>> 60ecb38452a540eb3b866d67bc8f73caee70ae99
        }
    }
}
