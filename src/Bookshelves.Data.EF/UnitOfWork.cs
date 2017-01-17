using System;

namespace Bookshelves.Data.EF
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly BookshelvesDbContext _context;

        public UnitOfWork(BookshelvesDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            if (!_context.ChangeTracker.HasChanges())
            {
                return;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();

                    throw;
                }
            }
        }
    }
}
