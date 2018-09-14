using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Tudu.Models;
using Tudu.Services;

namespace Tudu.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly JsonPlaceholderService _jsonPlaceholderService;

        public TodoController(JsonPlaceholderService jsonPlaceholderService)
        {
            _jsonPlaceholderService = jsonPlaceholderService;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Todo>> List()
        {
            IEnumerable<Todo> todoItems = await _jsonPlaceholderService.GetTodoList();
            return todoItems;
        }
    }
}
