using System;

namespace BasicTestApp.Exceptions
{
    public class BasicTestException : Exception
    {
        public virtual ErrorDto Error { get; set; }

        public BasicTestException()
        {

        }
    }
}
