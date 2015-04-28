﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Accounting.PaymentOrder.Events
{
    public interface Invalidated : IEvent
    {
        Guid PaymentOrderId { get; set; }
    }
}