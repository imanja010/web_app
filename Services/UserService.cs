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

        private List<User> userList = new List<User>
        {
            new User()
            {
                Id=1,
                Email="optimus.denk@gmail.com",
                Username="Djole1",
                Password="volimJelenuKarleusu",
                Id=1,
               
            },
            new User()
            {
                Id=2,
                Email="djoletov.drugi.mejl@gmail.com",
                Username="Djole2",
                Password="VolimAcuLukasa",
                Id=2
            }
        };
    }
}
