using Reddit.Models;

namespace Reddit.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User CreateUser() {
             return new User { Name = Name, Email = Email };
        }
    }
}
