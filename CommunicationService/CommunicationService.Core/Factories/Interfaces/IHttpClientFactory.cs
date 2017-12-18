using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CommunicationService.Core.Factories.Interfaces
{
    public interface IHttpClientFactory
    {
        Task<HttpClient> Create(bool authorized = true);
    }
}