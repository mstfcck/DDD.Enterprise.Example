﻿using Demo.Library.Queries;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Configuration.PaymentMethod.Services
{
    [Api("Configuration")]
    [Route("/configuration/payment-method", "GET")]
    public class Index : PagedQuery<Responses.Index>
    {
    }
}