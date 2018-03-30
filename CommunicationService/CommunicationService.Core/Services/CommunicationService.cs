using CommunicationService.Core.Factories.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommunicationService.Core.Services
{
    public abstract class CommunicationService
    {
        public IHttpClientFactory ClientFactory { get; }

        public CommunicationService(IHttpClientFactory clientFactory)
        {
            ClientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
        }

        protected async Task<HttpClient> GetClient(bool authorized = true)
        {
            return await ClientFactory.Create(authorized);
        }

        protected async Task<T> GetAsync<T>(string route, bool anonymous = false, params object[] parameters)
        {
            using (var client = await GetClient(!anonymous))
            {
                var cts = new CancellationTokenSource();
                //TODO Create a setting for this
                cts.CancelAfter(100000);

                try
                {
                    var response = await client.GetAsync(string.Format(route, parameters), cts.Token);
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //await RenewAccessTokenIfNeeded();

                        response.Dispose();
                        response = await client.GetAsync(string.Format(route, parameters), cts.Token);
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                            throw new UnauthorizedAccessException();
                    }

                    if (response.Content == null)
                        throw new Exception(); //TODO create more suggestive exception for this case

                    var data = await response.Content.ReadAsStringAsync();

                    //TODO Create the throw exception for all status codes
                    //await ThrowExceptionIfServerError<StandardErrorResponse>(response.StatusCode, data);

                    //TODO check what happens when NotFound is returned
                    //if (response.StatusCode == HttpStatusCode.NotFound)
                    //    return default(T);

                    return JsonConvert.DeserializeObject<T>(data);
                }
                catch (TaskCanceledException ex)
                {
                    if (ex.CancellationToken != cts.Token)
                    {
                        throw new EntryPointNotFoundException();
                    }
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (JsonException ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (Exception ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
            }
        }

        protected async Task<bool> HeadAsync()
        {
            //TODO Check what happens from the memory point of view with object created by using when returning a value from insisde the using statement
            using (var client = await GetClient())
            {
                var cts = new CancellationTokenSource();
                cts.CancelAfter(5000);

                try
                {
                    //TODO Properly provide the endpoint that is going to be validated
                    var headRequest = new HttpRequestMessage(HttpMethod.Head, "www.endpoint.com");
                    var response = await client.SendAsync(headRequest, cts.Token);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                        return false;
                }
                catch (TaskCanceledException ex)
                {
                    if (ex.CancellationToken != cts.Token)
                    {
                        throw new EntryPointNotFoundException();
                    }
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (Exception ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
            }
            return true;
        }

        protected async Task<T> PostAsync<M, T>(M model, string route, bool anonymous = false, params object[] parameters)
        {
            using (var client = await GetClient(!anonymous))
            {
                var requestPayload = model == null ? string.Empty : JsonConvert.SerializeObject(model);
                var requestContent = new StringContent(requestPayload, Encoding.UTF8, "application/json");

                var cts = new CancellationTokenSource();
                //TODO Create a setting for this
                cts.CancelAfter(1000000);

                try
                {
                    var response = await client.PostAsync(string.Format(route, parameters), requestContent, cts.Token);
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //await RenewAccessTokenIfNeeded();

                        response.Dispose();
                        response = await client.PostAsync(string.Format(route, parameters), requestContent, cts.Token);
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            throw new UnauthorizedAccessException();
                        }
                    }

                    var data = await response.Content.ReadAsStringAsync();

                    //TODO Create the throw exception for all status codes
                    //await ThrowExceptionIfServerError<StandardErrorResponse>(response.StatusCode, data);

                    //TODO check what happens when NotFound is returned
                    //if (response.StatusCode == HttpStatusCode.NotFound)
                    //    return default(T);

                    return JsonConvert.DeserializeObject<T>(data);
                }
                catch (TaskCanceledException ex)
                {
                    if (ex.CancellationToken != cts.Token)
                    {
                        throw new EntryPointNotFoundException();
                    }
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (JsonException ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (Exception ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
            }
        }

        protected async Task<T> PutAsync<M, T>(M model, string route, bool anonymous = false, params object[] parameters)
        {
            using (var client = await GetClient(!anonymous))
            {
                var requestPayload = model == null ? string.Empty : JsonConvert.SerializeObject(model);
                var requestContent = new StringContent(requestPayload, Encoding.UTF8, "application/json");

                var cts = new CancellationTokenSource();
                //TODO Create a setting for this
                cts.CancelAfter(1000000);

                try
                {
                    var response = await client.PutAsync(string.Format(route, parameters), requestContent, cts.Token);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //await RenewAccessTokenIfNeeded();

                        response.Dispose();
                        response = await client.PutAsync(string.Format(route, parameters), requestContent, cts.Token);
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            throw new UnauthorizedAccessException();
                        }
                    }

                    var data = await response.Content.ReadAsStringAsync();

                    //TODO Create the throw exception for all status codes
                    //await ThrowExceptionIfServerError<StandardErrorResponse>(response.StatusCode, data);

                    //TODO check what happens when NotFound is returned
                    //if (response.StatusCode == HttpStatusCode.NotFound)
                    //    return default(T);

                    return JsonConvert.DeserializeObject<T>(data);
                }
                catch (TaskCanceledException ex)
                {
                    if (ex.CancellationToken != cts.Token)
                    {
                        throw new EntryPointNotFoundException();
                    }
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (JsonException ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (Exception ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
            }
        }

        protected async Task<T> DeleteAsync<T>(string route, bool anonymous = false, params object[] parameters)
        {
            using (var client = await GetClient(!anonymous))
            {
                var cts = new CancellationTokenSource();
                //TODO Create a setting for this
                cts.CancelAfter(1000000);

                try
                {
                    var response = await client.DeleteAsync(string.Format(route, parameters), cts.Token);

                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //await RenewAccessTokenIfNeeded();

                        response.Dispose();
                        response = await client.DeleteAsync(string.Format(route, parameters), cts.Token);
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            throw new UnauthorizedAccessException();
                        }
                    }
                    
                    var data = await response.Content.ReadAsStringAsync();

                    //TODO Create the throw exception for all status codes
                    //await ThrowExceptionIfServerError<StandardErrorResponse>(response.StatusCode, data);

                    //TODO check what happens when NotFound is returned
                    //if (response.StatusCode == HttpStatusCode.NotFound)
                    //    return default(T);

                    return JsonConvert.DeserializeObject<T>(data);
                }
                catch (TaskCanceledException ex)
                {
                    if (ex.CancellationToken != cts.Token)
                    {
                        throw new EntryPointNotFoundException();
                    }
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (JsonException ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
                catch (Exception ex)
                {
                    //TODO Check how to properly throw this kind of exception
                    throw ex;
                }
            }
        }
    }
}