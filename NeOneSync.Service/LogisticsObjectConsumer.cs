using MassTransit;
using MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeOneSync.Service
{
    internal class LogisticsObjectConsumer : IConsumer<TestMessage>
    {
        ILogger<LogisticsObjectConsumer> _logger;
        public LogisticsObjectConsumer(ILogger<LogisticsObjectConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<TestMessage> context)
        {
            _logger.LogInformation($"Message received : {context.Message.Content}");
            return Task.CompletedTask;
                
        }
    }
}
