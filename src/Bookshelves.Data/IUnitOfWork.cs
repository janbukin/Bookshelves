using System.Threading.Tasks;

namespace Bookshelves.Data
{
    public interface IUnitOfWork
    {
        void Commit();

        Task CommitAsync();
    }
}
