using Microsoft.EntityFrameworkCore;
using Bragon_Ball_c_.Models;

namespace Bragon_Ball_c_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CharacterModel> Characters { get; set; }
    }
}
