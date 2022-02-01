using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace Azure.Resource.Test.ServiceBus.Services
{
    internal class ServiceBusManager
    {

        // connection string to your Service Bus namespace
        private readonly string connectionString;

        // the client that owns the connection and can be used to create senders and receivers
        ServiceBusClient client;

        // the sender used to publish messages to the queue
        ServiceBusSender sender;

        public ServiceBusManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal async Task SendMessagesWithPropertiesAsync(string topicName, int numOfMessages, string destination)
        {
            string[] companyCode = new string[] { "RQ", "JP", "AL", "IB" };

            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(topicName);

            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();


            for (int i = 1; i <= numOfMessages; i++)
            {
                Random r = new Random();
                int index = r.Next(0, companyCode.Length); //for ints

                var message = new ServiceBusMessage($"Message {companyCode[index]}");

                message.MessageId = Guid.NewGuid().ToString();
                message.ApplicationProperties.Add("CompanyCode", companyCode[index]);
                message.ApplicationProperties.Add("Destination", destination);

                if (!messageBatch.TryAddMessage(message))
                {
                    // if it is too large for the batch
                    throw new Exception($"The message {companyCode[index]} is too large to fit in the batch.");
                }
            }

            try
            {
                // Use the producer client to send the batch of messages to the Service Bus topic
                await sender.SendMessagesAsync(messageBatch);
                Console.WriteLine($"A batch of {numOfMessages} messages has been published to the topic.");
            }
            finally
            {
                // Calling DisposeAsync on client types is required to ensure that network
                // resources and other unmanaged objects are properly cleaned up.
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }

        }

        internal async Task SendMessagesAsync(string topicName, int numOfMessages)
        {
            // The Service Bus client types are safe to cache and use as a singleton for the lifetime
            // of the application, which is best practice when messages are being published or read
            // regularly.
            //
            // Create the clients that we'll use for sending and processing messages.
            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(topicName);

            // create a batch 
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            for (int i = 1; i <= numOfMessages; i++)
            {
                // try adding a message to the batch
                if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
                {
                    // if it is too large for the batch
                    throw new Exception($"The message {i} is too large to fit in the batch.");
                }
            }

            try
            {
                // Use the producer client to send the batch of messages to the Service Bus topic
                await sender.SendMessagesAsync(messageBatch);
                Console.WriteLine($"A batch of {numOfMessages} messages has been published to the topic.");
            }
            finally
            {
                // Calling DisposeAsync on client types is required to ensure that network
                // resources and other unmanaged objects are properly cleaned up.
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }
        }

    }
}
