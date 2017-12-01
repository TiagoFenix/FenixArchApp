using System;

namespace BasicTestApp.Sales.Model
{
    public class AccountResponseDto
    {
        public string AccountName { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }
    }
}
