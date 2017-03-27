using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;

namespace Bookshelves.Data.Repositories.Interfaces
{
	public interface IRepository<TEntity> where TEntity : Entity
	{
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetAsync(Guid id);

        void Add(TEntity entity);

		void Update(TEntity entity);

        void Delete(Guid id);

        void Delete(TEntity entity);
    }
}
