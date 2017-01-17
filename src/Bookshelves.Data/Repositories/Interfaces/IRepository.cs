using System;
using System.Collections.Generic;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.Repositories.Interfaces
{
	public interface IRepository<TEntity> where TEntity : Entity
	{
		IEnumerable<TEntity> GetAll();

		TEntity Get(Guid id);

        void Add(TEntity entity);

		void Update(TEntity entity);

        void Delete(Guid id);

        void Delete(TEntity entity);
    }
}
