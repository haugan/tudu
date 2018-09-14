namespace Tudu.Models.ViewModels.Users
{
    public class UserResponseItemViewModel
    {
        public UserResponseItemViewModel(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            Website = user.Website;
            Company = user.Company.Name;
            City = user.Address.City;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        
        public string Website { get; set; }

        public string Company { get; set; }

        public string City { get; set; }
    }
}
