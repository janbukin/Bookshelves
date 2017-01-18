using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace Bookshelves.Data.EF.Migrations.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookshelvesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            TargetDatabase = new DbConnectionInfo("BookshelvesConnection");
        }

        protected override void Seed(BookshelvesDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
