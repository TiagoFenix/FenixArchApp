﻿using System;

namespace BasicTestApp.Sales.Domain
{
    public class Account
    {
        public long id { get; set; }

        public string AccountName { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public Account()
        {

        }
    }
}
