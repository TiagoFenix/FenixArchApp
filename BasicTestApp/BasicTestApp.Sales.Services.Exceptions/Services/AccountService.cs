using System.Collections.Generic;
using BasicTestApp.Sales.Model;
using BasicTestApp.Sales.Services;
using System;
using BasicTestApp.Data;
using BasicTestApp.Sales.Domain;

namespace BasicTestApp.Sales.Services
{
    public class AccountService : IAccountService
    {
        private IAccountData _accountData;

        public AccountService(IAccountData accountData)
        {
            _accountData = accountData;
        }

        public AccountResponseDto CreateAccount(string userId, int userAge, decimal userCredit)
        {
            throw new System.NotImplementedException();
        }

        public AccountResponseDto GetAccount(string userId)
        {
             List<Account> accounts = _accountData.GetAll();


            return new AccountResponseDto() { AccountName = "Test", Created = DateTime.Now, CreatedBy = "Fenix" };
        }
    }
}
