using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories.Interfaces;

namespace Bookshelves.Data.EF.Repositories
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
	{
	    protected BookshelvesDbContext Context;

	    protected Repository(BookshelvesDbContext context)
	    {
	        Context = context;
	    }

	    protected DbSet<TEntity> Set
	    {
	        get { return Context.Set<TEntity>(); }
	    }

	    public IEnumerable<TEntity> GetAll()
		{ 
		    return Set.AsNoTracking().ToList();
		}

        public TEntity Get(Guid id)
        {
            return Set.Find(id);
        }

        public void Add(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
        }

		public void Update(TEntity entity)
		{
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            var stub = new TEntity {Id = id};
            Context.Entry(stub).State = EntityState.Deleted;
        }

        public void Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
        }
    }

}
