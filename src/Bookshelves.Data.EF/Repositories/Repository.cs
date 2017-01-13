using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories;

namespace Bookshelves.Data.EF.Repositories
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
	{
		protected ConcurrentDictionary<Guid, TEntity> _entities = new ConcurrentDictionary<Guid, TEntity>();

		public IEnumerable<TEntity> GetAll()
		{ 
			return _entities.Values;
		}

		public void Add(TEntity item)
		{
			item.Id = Guid.NewGuid();
			_entities[item.Id] = item;
		}

		public TEntity Get(Guid id)
		{
			TEntity item;
			_entities.TryGetValue(id, out item);
			return item;
		}

		public TEntity Remove(Guid id)
		{
			TEntity item;
			_entities.TryRemove(id, out item);
			return item;
		}

		public void Update(TEntity item)
		{
			_entities[item.Id] = item;
		}
	}

}
