using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Tudu.Models;
using Tudu.Models.ViewModels.Users;
using Tudu.Services;

namespace Tudu.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly JsonPlaceholderService _jsonPlaceholderService;
        private readonly List<UserResponseItemViewModel> _users;

        public UsersController(JsonPlaceholderService jsonPlaceholderService)
        {
            _jsonPlaceholderService = jsonPlaceholderService;
            _users = new List<UserResponseItemViewModel>();
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<UserResponseItemViewModel>> List()
        {
            IEnumerable<User> users = await _jsonPlaceholderService.GetUsersList();

            foreach (var user in users)
                _users.Add(new UserResponseItemViewModel(user));

            return _users;
        }
    }
}
