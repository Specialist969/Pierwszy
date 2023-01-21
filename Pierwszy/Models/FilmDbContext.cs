using Microsoft.EntityFrameworkCore;

namespace Pierwszy.Models
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options): base(options)
        {

        }
        public DbSet<Filmy> Films { get; set; }

    }
}
