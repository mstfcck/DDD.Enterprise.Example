﻿using Demo.Library.Responses;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Relations.Store.Services
{
    [Api("Relations")]
    [Route("/relations/store/{StoreId}/name", "PUT POST")]
    public class UpdateName : IReturn<Base<Command>>
    {
        public Guid StoreId { get; set; }

        public String Name { get; set; }
    }
}