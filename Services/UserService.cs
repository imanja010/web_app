using web_app.Models;

namespace web_app.Services
{
    public class UserService
    {
        public User GetUser(long id)
        {
            return userList.FirstOrDefault(X => X.Id == id);
        }
        public List<User> Get()
        {
            return userList; 
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }

        private List<User> userList = new List<User>
        {
            new User()
            {
                Id=1,
                Email="optimus.denk@gmail.com",
                Username="Djole1",
                Password="volimJelenuKarleusu",
               
            },
            new User()
            {
                Id=2,
                Email="djoletov.drugi.mejl@gmail.com",
                Username="Djole2",
                Password="VolimAcuLukasa",
            }
        };
    }
}
