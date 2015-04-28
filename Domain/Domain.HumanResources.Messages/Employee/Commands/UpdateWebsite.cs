﻿using Demo.Library.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.HumanResources.Employee.Commands
{
    public class UpdateWebsite : DemoCommand
    {
        public Guid EmployeeId { get; set; }

        public String Url { get; set; }
    }
}