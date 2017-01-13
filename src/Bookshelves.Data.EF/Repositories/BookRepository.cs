using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories;

namespace Bookshelves.Data.EF.Repositories
{
	public class BookRepository : Repository<Book>, IBookRepository
	{
		public BookRepository()
		{
			Add(new Book { Name = "ReWork" });
			Add(new Book { Name = "Remote" });
		}

		public IEnumerable<Book> GetByGenre(Guid genreId)
		{
			throw new NotImplementedException();
		}
	}
}
