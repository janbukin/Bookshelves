using System.Collections.Generic;

namespace Bookshelves.Domain.Core.DTO
{
	public class GenreDto
	{
		public string Name { get; set; }
        public IEnumerable<BookDto> Books { get; set; }
    }
}
