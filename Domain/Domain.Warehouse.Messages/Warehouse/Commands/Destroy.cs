﻿using Demo.Library.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Warehouse.Warehouse.Commands
{
    public class Destroy : DemoCommand
    {
        public Guid WarehouseId { get; set; }
    }
}