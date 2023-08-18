using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialConsole.Models;
using System.Net.Http;
using System.Text.Json;


namespace socialConsole.Controllers
{
    // PostController
    public class UserController
    {
        private readonly HttpClient _httpClient = new HttpClient();
        // https://jsonplaceholder.typicode.com/users
        private const string ApiBaseUrl = "https://jsonplaceholder.typicode.com";

    public async Task<List<User>> GetUsersAsync()
    {
        var response = await _httpClient.GetStringAsync($"{ApiBaseUrl}/users");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            IgnoreNullValues = true
        };
        var users = JsonSerializer.Deserialize<List<User>>(response, options);
        return users;
    }

    }
}