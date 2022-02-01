using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure.Resource.Test.Function
{
    public static class PlanningOrders
    {
        [FunctionName("PlanningOrders")]
        public static async Task Run(
            [ServiceBusTrigger("%TopicName%", "%SubscriptionName%", Connection = "ServiceBusConnString")] ServiceBusReceivedMessage message,
            [DurableClient] IDurableOrchestrationClient starter, ILogger log)
        {
            log.LogInformation($"{message.Body}");
        }
    }
}