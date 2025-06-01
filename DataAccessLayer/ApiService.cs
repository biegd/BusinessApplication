using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataAccessLayer
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;


        public ApiService(string apiUrl)
        {
            _apiUrl = Environment.GetEnvironmentVariable("API_URL")
                ?? throw new InvalidOperationException("API_URL environment variable is not set.");
            _httpClient = new HttpClient();

        }

        public async Task<string> GetDataFromApiAsync(string endpoint)
        {

            HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

        }
    }
}
