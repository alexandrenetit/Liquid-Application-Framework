﻿using Liquid.Messaging.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Liquid.Messaging.Kafka.Tests.Mock
{
    public class WorkerMock : ILiquidWorker<MessageMock>
    {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task ProcessMessageAsync(ProcessMessageEventArgs<MessageMock> args, CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return;
        }
    }
}
