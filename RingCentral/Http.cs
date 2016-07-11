using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class RestClient
    {
        public Task<HttpResponseMessage> Get(string endpoint, object queryParams = null)
        {
            var url = server.AppendPathSegment(endpoint).SetQueryParams(queryParams);
            var client = new FlurlClient(url);
            if (token != null)
            {
                client = client.WithOAuthBearerToken(token.access_token);
            }
            return client.GetAsync();
        }

        public Task<HttpResponseMessage> Post(string endpoint, object requestBody, object queryParams = null)
        {
            var url = server.AppendPathSegment(endpoint).SetQueryParams(queryParams);
            var client = new FlurlClient(url);
            if (token != null)
            {
                client = client.WithOAuthBearerToken(token.access_token);
            }
            return client.PostJsonAsync(requestBody);
        }

        public Task<HttpResponseMessage> Delete(string endpoint)
        {
            var url = server.AppendPathSegment(endpoint);
            var client = new FlurlClient(url);
            if (token != null)
            {
                client = client.WithOAuthBearerToken(token.access_token);
            }
            return client.DeleteAsync();
        }

        public async Task<T> Get<T>(string endpoint, object queryParams = null)
        {
            var response = await Get(endpoint, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }
    }
}