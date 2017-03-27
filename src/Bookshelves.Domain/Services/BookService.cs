using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories.Interfaces;
using Bookshelves.Domain.Core.DTO;
using Bookshelves.Domain.Core.Services;

namespace Bookshelves.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        

        public BookService(IBookRepository bookRepository, IGenreRepository genreRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetAsync(Guid id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public Task SaveBookAsync(BookDto bookDto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            _bookRepository.Delete(book);
        }
    }
}
