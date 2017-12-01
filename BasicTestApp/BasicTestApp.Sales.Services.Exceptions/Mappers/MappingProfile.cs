using AutoMapper;
using BasicTestApp.Sales.Domain;
using BasicTestApp.Sales.Model;

namespace BasicTestApp.Sales.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountResponseDto>();
            CreateMap<AccountRequestDto, Account>();
        }
    }
}
