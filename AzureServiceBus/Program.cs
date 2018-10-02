using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;


namespace AzureServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://enterprisesearchdev.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=pA8TSC0jep0/zOdeGuSoz5X7fxTSwOjFWAUnGU5nR1k=";
            var queueName = "synapsedev";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage("This is a test message!");

            Console.WriteLine(String.Format("Message id: {0}", message.MessageId));

            client.Send(message);

            Console.WriteLine("Message successfully sent! Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
