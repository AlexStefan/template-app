using CommunicationService.Core.Factories.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CommunicationService.Core.Factories
{
    public class HttpClientFactory : IHttpClientFactory
    {
        public HttpClientFactory()
        {

        }

        public async Task<HttpClient> Create(bool authorized = true)
        {
            var serverUrl = new Uri("http://app-stub-address.com");

            var client = new HttpClient();
            client.BaseAddress = serverUrl;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (client.DefaultRequestHeaders.CacheControl == null)
                client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue();

            client.DefaultRequestHeaders.CacheControl.NoCache = true;
            client.DefaultRequestHeaders.IfModifiedSince = DateTime.UtcNow;
            client.DefaultRequestHeaders.CacheControl.NoStore = true;

            client.Timeout = new TimeSpan(1000000);

            return client;
        }
    }
}