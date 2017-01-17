using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories.Interfaces;

namespace Bookshelves.Data.EF.Repositories
{
	public class BookRepository : Repository<Book>, IBookRepository
	{
	    public BookRepository(BookshelvesDbContext context) : base(context)
	    {
	    }
        
		public IEnumerable<Book> GetByGenre(Guid genreId)
		{
			throw new NotImplementedException();
		}
	}
}
