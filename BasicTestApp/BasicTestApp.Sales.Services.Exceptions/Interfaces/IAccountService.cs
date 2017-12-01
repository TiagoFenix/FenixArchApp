using BasicTestApp.Sales.Model;
using System.Collections.Generic;

namespace BasicTestApp.Sales.Services
{
    public interface IAccountService
    {
        AccountResponseDto GetAccount(string userId);

        AccountResponseDto CreateAccount(string userId, int userAge, decimal userCredit);
    }
}
