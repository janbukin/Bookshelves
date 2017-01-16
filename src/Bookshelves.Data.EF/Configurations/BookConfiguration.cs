using System.Data.Entity.ModelConfiguration;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.EF.Configurations
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            
        }
    }
}
