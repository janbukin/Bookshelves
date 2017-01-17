using System.Collections.Generic;

namespace Bookshelves.Data.Model
{
	public class Book : Entity
	{
		public string Name { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
