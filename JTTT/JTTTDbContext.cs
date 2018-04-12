using System.Data.Entity;

namespace JTTT
{
    public class JTTTDbContext : DbContext
    {
        public JTTTDbContext() : base("jttt_db") { }

        public DbSet<Task> Task { get; set; }
    }
}
