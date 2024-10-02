using System.ComponentModel.DataAnnotations;

namespace BusinessAPI.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {
            
        }
        public override string ToString()
        {
            return $"Username: {Username} / Email: {Email}";
        }
    }
}
