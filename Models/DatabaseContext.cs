using Microsoft.EntityFrameworkCore;

namespace IngilizceOgreniyorum.Models
{
    public class DatabaseContext(IConfiguration configuration) : DbContext
    {
        private readonly IConfiguration _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
