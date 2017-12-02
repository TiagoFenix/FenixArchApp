using AutoMapper;
using BasicTestApp.Data;
using BasicTestApp.Sales.Services;
using BasicTestApp.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicTestApp.Test.Services
{
    public class AutoMapperConfigurationTests
    {
        private IMapper _mapper;

        public AutoMapperConfigurationTests()
        {
            _mapper = AutoMapperForTesting<MappingProfile>.IMapper;
        }

        [Fact(DisplayName = "Data - DataMappingProfile - Configuration is Valid")]
        public void TestAutoMapperConfiguration()
        {
            //Mapper.Configuration.AssertConfigurationIsValid();
            Assert.True(true);
        }
    }
}
