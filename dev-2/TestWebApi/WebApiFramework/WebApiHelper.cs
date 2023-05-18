using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApiFramework.ApiEntites;

namespace WebApiFramework
{
    public class WebApiHelper
    {
        private const string API_END_POINT = "https://localhost:7254/api/browsers";

        private WebApiClient WebApiClient => new();

        public async Task<IEnumerable<Browser>?> GetTypedRequest() => await WebApiClient.Get(API_END_POINT).Result.Content.ReadFromJsonAsync<IEnumerable<Browser>>();

        public async Task<object> GetUnTypedRequest() => await WebApiClient.GetUnTyped(API_END_POINT, typeof(IEnumerable<Browser>));

        public async Task<HttpResponseMessage> PostRequest(List<Browser> browsers) => await WebApiClient.Post<List<Browser>>(API_END_POINT, browsers);

        public async Task<HttpResponseMessage> PutRequest(Browser browser) => await WebApiClient.Put<Browser>(API_END_POINT, browser);

        public async Task<HttpResponseMessage> DeleteRequest(int id) => await WebApiClient.Delete($"{API_END_POINT}/{id}");
    }
}
