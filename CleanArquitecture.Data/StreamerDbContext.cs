using CleanArquitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

namespace CleanArquitecture.Data
{
    public class StreamerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\; Initial Catalog=Streamer; Integrated Security=True");
            .LogTo(Console.WriteLine, new[] {Dblo})
        }
        public DbSet<Streamer> Streamers { get; set; }
        public DbSet<Video> Videos { get; set; }


    }
}
