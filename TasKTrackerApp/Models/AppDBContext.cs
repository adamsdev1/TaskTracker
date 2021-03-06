using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TasKTrackerApp.Models
{
    public class AppDBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        //public AppDBContext(DbContextOptions options) : base(options)
        //{
        //    _options = options;
        //}

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
