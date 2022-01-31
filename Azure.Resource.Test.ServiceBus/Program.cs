using Azure.Resource.Test.ServiceBus.Services;
using System;
using System.Threading.Tasks;

namespace Azure.Resource.Test.ServiceBus
{
    class Program
    {
        static string connectionString = "Endpoint=sb://mrp-servicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=ym17KNNHElHfuygcT6gnVFM16pwHHI4O/lLM8USVoPk=";

        // number of messages to be sent to the queue
        const int numOfMessages = 10;

        static async Task Main()
        {
            // name of your Service Bus topic
            string topicName = "saleorderevents";
            string subscriptionName = "ProductionPlanningOrders";

            ServiceBusManager manager = new ServiceBusManager(connectionString);
            await manager.SendMessagesAsync(topicName, numOfMessages);

            await manager.SendMessagesWithPropertiesAsync(topicName, numOfMessages, subscriptionName);

            Console.WriteLine("Press any key to end the application");
            Console.ReadKey();
        }
    }
}
