﻿using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IAccountRepository
    {
        ICollection<Account> GetAccounts();
        Account GetAccount(Guid Id);
        Account GetAccount(string Name);
        bool AccountsExits(Guid Id);
    }
}
