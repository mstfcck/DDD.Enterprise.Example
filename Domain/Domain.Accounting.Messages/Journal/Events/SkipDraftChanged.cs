﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Accounting.Journal.Events
{
    public interface SkipDraftChanged : IEvent
    {
        Guid JournalId { get; set; }
        Boolean SkipDraft { get; set; }
    }
}
