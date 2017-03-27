using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Domain.Core.DTO;
using Bookshelves.Domain.Core.Services;

namespace Bookshelves.Domain.Services
{
    public class BookService : IBookService
    {
        public BookService()
        {
            
        }

        public Task<Book> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync(BookDto bookDto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
