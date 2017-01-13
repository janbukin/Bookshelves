using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories;

namespace Bookshelves.Data.EF.Repositories
{
	public class GenreRepository : Repository<Genre>, IGenreRepository
	{
		public GenreRepository()
		{
			Add(new Genre { Name = "Business-Novel"});
			Add(new Genre { Name = "Fiction" });
		}

		public IEnumerable<Book> GetByBook(Guid bookId)
		{
			throw new NotImplementedException();
		}
	}
}
