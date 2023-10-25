using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<ArtOwner> ArtOwner { get; set; }
        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
