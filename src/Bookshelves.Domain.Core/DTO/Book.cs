using System.Collections.Generic;

namespace Bookshelves.Domain.Core.DTO
{
	public class BookDto
	{
		public string Name { get; set; }

        public IEnumerable<GenreDto> Genres { get; set; }
    }
}
