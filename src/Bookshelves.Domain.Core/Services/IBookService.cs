using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Domain.Core.DTO;

namespace Bookshelves.Domain.Core.Services
{
    public interface IBookService
    {
        Task<Book> GetAsync(Guid id);

        Task<List<Book>> GetAllAsync();

        Task SaveChangesAsync(BookDto bookDto);

        Task Delete(Guid id);
    }
}
