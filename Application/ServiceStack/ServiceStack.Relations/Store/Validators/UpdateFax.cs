﻿using Demo.Library.Command;
using ServiceStack;
using ServiceStack.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Relations.Store.Validators
{
    public class UpdateFax : AbstractValidator<Services.UpdateFax>
    {
        public UpdateFax()
        {
            RuleFor(x => x.StoreId).NotEmpty();
        }
    }
}