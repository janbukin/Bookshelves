using System;
namespace Bookshelves.Data.Model
{
	public class Book : Entity
	{
		public string Name { get; set; }

		public Guid[] Genres { get; set; }
	}
}
