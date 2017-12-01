using AutoMapper;
using BasicTestApp.DataStore.Schema;
using BasicTestApp.Sales.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTestApp.Data
{
    public class SqlDataMappingProfile : Profile
    {
        public SqlDataMappingProfile()
        {
            CreateMap<Account, AccountDataModel>();
            CreateMap<AccountDataModel, Account>(); 
        }
    }
}
