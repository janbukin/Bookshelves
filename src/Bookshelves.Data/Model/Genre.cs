using System.Collections.Generic;

namespace Bookshelves.Data.Model
{
	public class Genre : Entity
	{
		public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
