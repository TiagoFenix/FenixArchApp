using System;
using System.Collections.Generic;
using BasicTestApp.Sales.Domain;
using BasicTestApp.DataStore;
using System.Linq;
using BasicTestApp.DataStore.Schema;
using AutoMapper;

namespace BasicTestApp.Data
{
    public class SqlAccountData : IAccountData
    {
        private BasicTestAppDbContext _DbContext;
        private IMapper _mapper;

        public SqlAccountData(BasicTestAppDbContext context, IMapper mapper)
        {
            _DbContext = context;
            _mapper = mapper;
        }

        public Account Create(Account account)
        {
            AccountDataModel acct = _mapper.Map<AccountDataModel>(account);
            _DbContext.Accounts.Add(acct);
            _DbContext.SaveChanges();
            return account;
        }

        public Account Get(long id)
        {
            return _mapper.Map<Account>(_DbContext.Accounts.FirstOrDefault(a => a.AccountId == id));
        }

        public List<Account> GetAll()
        {
            return _mapper.Map<List<Account>>(_DbContext.Accounts.OrderBy(a => a.AccountName).ToList());
        }
    }
}
