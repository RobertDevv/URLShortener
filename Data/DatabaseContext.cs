using Microsoft.EntityFrameworkCore;
using URLShortener.Data.Models;

namespace URLShortener.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Redirects> Redirects { get; set; }
        public DbSet<Referrals> Referrals { get; set; }
        public string filePath { get; }

        public DatabaseContext()
        {
#if DEBUG
        filePath = Directory.GetCurrentDirectory() + "\\db\\URLShortener.db"; // Windows
#else
        filePath = Directory.GetCurrentDirectory() + "/db/URLShortener.db"; // Linux
#endif
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={filePath}");
    }
}
