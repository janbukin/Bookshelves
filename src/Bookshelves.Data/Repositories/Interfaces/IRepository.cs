using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.Repositories
{
	public interface IRepository<TEntity> where TEntity : Entity
	{
		void Add(TEntity item);

		IEnumerable<TEntity> GetAll();

		TEntity Get(Guid id);

		TEntity Remove(Guid id);

		void Update(TEntity item);
	}
}
