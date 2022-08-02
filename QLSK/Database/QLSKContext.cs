using Microsoft.EntityFrameworkCore;

namespace QLSK.Database
{
    public class QLSKContext:DbContext
    {
        public QLSKContext(DbContextOptions<QLSKContext> options) : base(options)
        { }
        public DbSet<Category> Category { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> PhieuDKSK { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
