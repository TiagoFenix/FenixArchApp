using BasicTestApp.DataStore.Schema;
using BasicTestApp.Sales.Domain;
using System.Collections.Generic;
using System.Linq;

namespace BasicTestApp.Data
{
    public interface IAccountData
    {
        List<Account> GetAll();
        Account Get(long id);
        Account Create(Account account);
    }
}
