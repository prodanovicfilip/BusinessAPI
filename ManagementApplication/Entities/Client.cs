using System.ComponentModel.DataAnnotations;

namespace ManagementApplication.Entities
{
    public class Client : BaseEntity
    {
        public string Address { get; set; }
        public Client()
        {
            
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} / Email: {Email}";
        }
    }
}
