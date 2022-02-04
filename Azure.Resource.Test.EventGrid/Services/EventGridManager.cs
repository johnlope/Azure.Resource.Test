using Azure.Resource.Test.EventGrid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Resource.Test.Services.EventGrid
{
    public class EventGridManager
    {
        private readonly string topicHostname;
        private readonly string topicKey;
        private const string HEADER_AZURE_EVENT_GRID_KEY = "aeg-sas-key";

        public EventGridManager(string topicHostname, string topicKey)
        {
            this.topicHostname = topicHostname;
            this.topicKey = topicKey;
        }

        public async Task PublishEventsAsync(string jsonContent)
        {
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add(HEADER_AZURE_EVENT_GRID_KEY, topicKey);

                var stringContent = new StringContent(jsonContent);
                HttpResponseMessage httpresponse = await httpClient.PostAsync(new Uri(topicHostname), stringContent);
            }
        }
    }
}
