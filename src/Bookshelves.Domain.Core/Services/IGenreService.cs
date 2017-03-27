using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Domain.Core.DTO;

namespace Bookshelves.Domain.Core.Services
{
    public interface IGenreService
    {
        Task<Genre> GetAsync(Guid id);

        Task<List<Genre>> GetAllAsync();

        Task SaveChangesAsync(GenreDto bookDto);

        Task Delete(Guid id);
    }
}
