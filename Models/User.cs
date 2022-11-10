using System.Security.Cryptography.X509Certificates;

namespace web_app.Models
{
    public class User
    {

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
