﻿using Aggregates;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Configuration.AccountType
{
    public class Handler :
        IHandleMessagesAsync<Commands.ChangeDeferral>,
        IHandleMessagesAsync<Commands.ChangeDescription>,
        IHandleMessagesAsync<Commands.ChangeName>,
        IHandleMessagesAsync<Commands.Create>,
        IHandleMessagesAsync<Commands.Destroy>
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;

        public Handler(IUnitOfWork uow, IBus bus)
        {
            _uow = uow;
            _bus = bus;
        }

        public async Task Handle(Commands.ChangeDeferral command, IHandleContext ctx)
        {
            var account = await _uow.For<AccountType>().Get(command.AccountTypeId);
            account.ChangeDeferral(command.DeferralMethod);
        }

        public async Task Handle(Commands.ChangeDescription command, IHandleContext ctx)
        {
            var account = await _uow.For<AccountType>().Get(command.AccountTypeId);
            account.ChangeDescription(command.Description);
        }

        public async Task Handle(Commands.ChangeName command, IHandleContext ctx)
        {
            var account = await _uow.For<AccountType>().Get(command.AccountTypeId);
            account.ChangeName(command.Name);
        }

        public async Task Handle(Commands.Create command, IHandleContext ctx)
        {
            var account = await _uow.For<AccountType>().New(command.AccountTypeId);
            account.Create(command.Name, command.DeferralMethod, command.ParentId);
        }

        public async Task Handle(Commands.Destroy command, IHandleContext ctx)
        {
            var account = await _uow.For<AccountType>().Get(command.AccountTypeId);
            account.Destroy();
        }
    }
}