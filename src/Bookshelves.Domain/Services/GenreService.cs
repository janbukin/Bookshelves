using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Data.Repositories.Interfaces;
using Bookshelves.Domain.Core.DTO;
using Bookshelves.Domain.Core.Services;

namespace Bookshelves.Domain.Services
{
    public class GenreService: IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<Genre> GetAsync(Guid id)
        {
            return await _genreRepository.GetAsync(id);
        }

        public async Task<List<Genre>> GetAllAsync()
        {
            return await _genreRepository.GetAllAsync();
        }

        public Task SaveChangesAsync(GenreDto bookDto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            var book = await _genreRepository.GetAsync(id);

            _genreRepository.Delete(book);
        }
    }
}
