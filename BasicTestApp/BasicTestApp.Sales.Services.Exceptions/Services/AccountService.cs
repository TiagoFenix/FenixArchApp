using System.Collections.Generic;
using BasicTestApp.Sales.Model;
using BasicTestApp.Sales.Services;
using System;
using BasicTestApp.Data;
using BasicTestApp.Sales.Domain;
using AutoMapper;

namespace BasicTestApp.Sales.Services
{
    public class AccountService : IAccountService
    {
        private IAccountData _accountData;
        private IMapper _mapper;

        public AccountService(IAccountData accountData, IMapper mapper)
        {
            _accountData = accountData;
            _mapper = mapper;
        }

        public AccountResponseDto CreateAccount(string userId, int userAge, decimal userCredit)
        {
            throw new System.NotImplementedException();
        }

        public AccountResponseDto GetAccount(string userId)
        {
             List<Account> accounts = _accountData.GetAll();
            return _mapper.Map<AccountResponseDto>(accounts[0]);
        }
    }
}
