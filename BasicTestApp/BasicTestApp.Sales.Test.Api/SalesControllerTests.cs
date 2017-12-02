using AutoMapper;
using BasicTestApp.Api.Controllers;
using BasicTestApp.Data;
using BasicTestApp.DataStore;
using BasicTestApp.Sales.Model;
using BasicTestApp.Sales.Services;
using BasicTestApp.Test.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BasicTestApp.Test.Api
{
    public class SalesControllerTests
    {
        private IMapper _mapper;
        private IMapper _sqlmapper;

        public SalesControllerTests()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            _mapper = new Mapper(config);

            var sqlconfig = new MapperConfiguration(cfg => cfg.AddProfile(new SqlDataMappingProfile()));
            _sqlmapper = new Mapper(sqlconfig);
        }

        private SalesController GetController(BasicTestAppDbContext context)
        {

            IAccountData accountData = new SqlAccountData(context, _sqlmapper);
            IAccountService accountService = new AccountService(accountData, _mapper);
            return new SalesController(accountService);
        }


        [Fact(DisplayName = "Sales Controller Tests - Get Account By Name - Success")]
        public void GetAccountByName_Success()
        {
            using (BasicTestAppDbContext context = CreateInMemorianDB.CreateFreshInMemory())
            {
                //Arrange
                string userId = "ValidName";
                SalesController ctrl = GetController(context);

                //Act
                var result = ctrl.Get(userId);

                //Assert
                Assert.IsType<OkObjectResult>(result);

                OkObjectResult objectResult = (OkObjectResult)result;
                Assert.Equal(200, objectResult.StatusCode);
                Assert.IsAssignableFrom<AccountResponseDto>(objectResult.Value);

                AccountResponseDto response = (AccountResponseDto)objectResult.Value;
                Assert.Equal("Test", response.AccountName);
                Assert.True(response.CreatedBy.Contains("Fenix"));
            }
        }
    }
}
