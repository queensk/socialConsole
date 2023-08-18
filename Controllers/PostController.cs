using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;
using System.Text.Json;
using System.Net.Http;
namespace socialConsole.Controllers
{
    public class PostController
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiBaseUrl = "https://jsonplaceholder.typicode.com";

        public async Task<List<Post>> GetPosts(string userId)
        {
            var response = await _httpClient.GetAsync($"{ApiBaseUrl}/posts?userId={userId}");
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IgnoreNullValues = true
            };
            var posts = JsonSerializer.Deserialize<List<Post>>(response.Content.ReadAsStringAsync().Result, options);
            return posts;
        }
    }
}
