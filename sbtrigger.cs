using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace sbtrigger2
{
    public class sbtrigger
    {
        [FunctionName("sbtrigger")]
        public void Run([ServiceBusTrigger("myqueue", Connection = "sbconnstring")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
