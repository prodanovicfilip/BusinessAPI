using BusinessAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessAPI
{
    public class ApiContext : DbContext
    {
        public ApiContext()
        {
            
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EBPQHUK;Initial Catalog=BusinessDB;Integrated Security=SSPI;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
