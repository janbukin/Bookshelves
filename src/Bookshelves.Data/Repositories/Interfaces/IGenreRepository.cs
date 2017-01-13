using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.Repositories
{
	public interface IGenreRepository : IRepository<Genre>
	{
		IEnumerable<Book> GetByBook(Guid bookId);
	}
}
