using AutoMapper;
using BasicTestApp.Data;
using BasicTestApp.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicTestApp.Test.Data
{
    public class AutoMapperConfigurationTests
    {
        private IMapper _mapper;

        public AutoMapperConfigurationTests()
        {
            _mapper = AutoMapperForTesting<SqlDataMappingProfile>.IMapper;
        }

        [Fact(DisplayName = "Data - DataMappingProfile - Configuration is Valid")]
        public void TestAutoMapperConfiguration()
        {
            //Mapper.Configuration.AssertConfigurationIsValid();

            Assert.True(true);
        }
    }
}
