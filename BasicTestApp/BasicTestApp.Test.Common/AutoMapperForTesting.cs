using AutoMapper;
using System;
using Xunit;

namespace BasicTestApp.Test.Common
{
    public class AutoMapperForTesting<T> where T : AutoMapper.Profile, new()
    {
        private static IMapper _mapper;

        public AutoMapperForTesting()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<T>();
            });

            _mapper = Mapper.Configuration.CreateMapper();
        }

        public static IMapper IMapper { get { return _mapper; } }
    }
}
