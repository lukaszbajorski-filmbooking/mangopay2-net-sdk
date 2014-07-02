﻿using MangoPay.Core;
using MangoPay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MangoPay.Entities.Dependend
{
    /// <summary>Class represents US type of bank account.</summary>
    public class BankAccountDetailsUS : Dto, IBankAccountDetails
    {
        /// <summary>Account number.</summary>
        public String AccountNumber;

        /// <summary>ABA.</summary>
        public String ABA;
    }
}
