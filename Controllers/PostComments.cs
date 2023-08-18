using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;
using System.Text.Json;


namespace socialConsole.Controllers
{
    public class PostComments
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiBaseUrl = "https://jsonplaceholder.typicode.com";

        public async Task<List<Comment>> GetComments(string userId)
        {
            var response = await _httpClient.GetAsync($"{ApiBaseUrl}/posts?userId={userId}");
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IgnoreNullValues = true
            };
            var Comments = JsonSerializer.Deserialize<List<Comment>>(response.Content.ReadAsStringAsync().Result, options);
            return Comments;
        }
    }
}