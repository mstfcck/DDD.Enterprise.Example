﻿using Demo.Library.Command;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Accounting.Currency.Commands
{
    public class Deactivate : DemoCommand
    {
        public Guid CurrencyId { get; set; }
    }
}