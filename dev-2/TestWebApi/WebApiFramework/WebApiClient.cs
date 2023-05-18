using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApiFramework
{
    public class WebApiClient
    {
        static HttpClient httpClient = new HttpClient();

        public async Task<HttpResponseMessage> Get(string url) => await httpClient.GetAsync(url);

        public async Task<object?> GetUnTyped(string url, Type type) => await httpClient.GetFromJsonAsync(url, type);

        public async Task<HttpResponseMessage> Post<T>(string url, T content) => await httpClient.PostAsJsonAsync(url, content);

        public async Task<HttpResponseMessage> Put<T>(string url, T content) => await httpClient.PutAsJsonAsync(url, content);

        public async Task<HttpResponseMessage> Delete(string url) => await httpClient.DeleteAsync(url);
    }
}
