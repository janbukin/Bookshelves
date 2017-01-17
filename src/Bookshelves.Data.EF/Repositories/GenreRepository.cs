using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories.Interfaces;

namespace Bookshelves.Data.EF.Repositories
{
	public class GenreRepository : Repository<Genre>, IGenreRepository
	{
		public GenreRepository(BookshelvesDbContext context) : base(context)
        {
		}

		public IEnumerable<Book> GetByBook(Guid bookId)
		{
			throw new NotImplementedException();
		}
	}
}
