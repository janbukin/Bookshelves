using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bookshelves.Data.EF.Configurations;
using Bookshelves.Data.EF.Conventions;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.EF
{
    public class BookshelvesDbContext : DbContext
    {
        public BookshelvesDbContext(string connStringName) : base(connStringName)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add(new GuidIdentityConvention());

            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
