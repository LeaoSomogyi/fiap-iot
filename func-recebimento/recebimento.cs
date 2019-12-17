using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.EventHubs;
using System.Text;
using Microsoft.Extensions.Logging;

namespace func_recebimento
{
    public static class recebimento
    {
        [FunctionName("recebimento")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "Connection", ConsumerGroup = "AFunc")]EventData message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {Encoding.UTF8.GetString(message.Body.Array)}");
        }
    }
}