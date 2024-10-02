using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ManagementApplication.Services
{
    public class ApiService : IApiService
    {
        private readonly string _baseUrl = "http://localhost:5160/api/";
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<T>> GetAll<T>(string fieldName)
        {
            IEnumerable<T> output;
            var endPoint = _baseUrl + fieldName;
            var response = await _httpClient.GetAsync(endPoint);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(data))
                {
                    return Enumerable.Empty<T>();
                }
                output = JsonConvert.DeserializeObject<IEnumerable<T>>(data);
                return output;
            }
            return Enumerable.Empty<T>();
        }
        public async Task<T> GetById<T>(int id, string fieldName)
        {
            var endPoint = _baseUrl + fieldName + "/" + id;
            var response = await _httpClient.GetAsync($"{endPoint}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(data))
                {
                    return default;
                }
                return JsonConvert.DeserializeObject<T>(data);
            }
            return default;
        }
        public async Task<T> Update<T>(int id, T value, string fieldName)
        {
            var endPoint = _baseUrl + fieldName + "/" + id;
            var json = JsonConvert.SerializeObject(value);
            var request = new StringContent(json, new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            var response = await _httpClient.PostAsync(endPoint, request);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(data))
                {
                    return default;
                }
                return JsonConvert.DeserializeObject<T>(data);
            }
            return default;
        }
        public async Task Create<T>(T value, string fieldName)
        {
            var endPoint = _baseUrl + fieldName;
            var json = JsonConvert.SerializeObject(value);
            var request = new StringContent(json, Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(endPoint, request);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }
        }
        public async Task Delete<T>(int id, string fieldName)
        {
            var endPoint = _baseUrl + fieldName + "/" + id;
            var response = await _httpClient.DeleteAsync(endPoint);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }
        }
    }
}
