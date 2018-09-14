using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Tudu.Constants;
using Tudu.Models;

namespace Tudu.Services
{
    public class JsonPlaceholderService
    {
        private readonly HttpClient _client;

        public JsonPlaceholderService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Todo>> GetTodoList()
        {
            IEnumerable<Todo> result;

            try
            {
                var response = await _client.GetAsync(ApiEndpoint.Todos);
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsAsync<IEnumerable<Todo>>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured while calling endpoint: '{ApiEndpoint.Todos}'! Exception message: '{e.Message}'");
                result = Array.Empty<Todo>();
            }

            return result;
        }

        public async Task<IEnumerable<User>> GetUsersList()
        {
            IEnumerable<User> result;

            try
            {
                var response = await _client.GetAsync(ApiEndpoint.Users);
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsAsync<IEnumerable<User>>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured while calling endpoint: '{ApiEndpoint.Users}'! Exception message: '{e.Message}'");
                result = Array.Empty<User>();
            }

            return result;
        }
    }
}
