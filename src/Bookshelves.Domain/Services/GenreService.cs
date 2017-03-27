using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookshelves.Data.Model;
using Bookshelves.Domain.Core.DTO;
using Bookshelves.Domain.Core.Services;

namespace Bookshelves.Domain.Services
{
    public class GenreService: IGenreService
    {
        public GenreService()
        {
            
        }

        public Task<Genre> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Genre>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync(GenreDto bookDto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
