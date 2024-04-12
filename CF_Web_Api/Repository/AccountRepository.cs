using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _dbcontext;
        public AccountRepository(DataContext dbcontext)
        {
               _dbcontext = dbcontext;
        }

        public bool AccountExits(Guid Id)
        {
            return _dbcontext.Accounts.Any(a=>a.Id==Id);
        }

        public Account GetAccount(Guid Id)
        {
           return _dbcontext.Accounts.Where(a=>a.Id==Id).FirstOrDefault();
        }

        public ICollection<Account> GetAccounts()
        {
            return _dbcontext.Accounts.ToList();
        }
    }
}
