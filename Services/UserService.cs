using web_app.Models;

namespace web_app.Services
{
    public class UserService
    {
        public User GetUser()
        {
            return new User()
            {
                Username = "TestUsername",
                Email = "TestEmail",
                Password = "TestPassword"
            };
        }
        private List<User> userList = new List<User>
        {
            new User()
            {
                Email="optimus.denk@gmail.com",
                Username="Djole1",
                Password="volimJelenuKarleusu"
            },
            new User()
            {
                Email="djoletov.drugi.mejl@gmail.com",
                Username="Djole2",
                Password="VolimAcuLukasa"
            }
        };
    }
}
