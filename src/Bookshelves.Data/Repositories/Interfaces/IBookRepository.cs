using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.Repositories.Interfaces
{
	public interface IBookRepository : IRepository<Book>
	{
		IEnumerable<Book> GetByGenre(Guid genreId);
	}
}
