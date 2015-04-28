﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Library.Command;

namespace Demo.Domain.Accounting.Tax.Commands
{
    public class Create : DemoCommand
    {
        public Guid TaxId { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public Guid TaxTypeId { get; set; }
    }
}