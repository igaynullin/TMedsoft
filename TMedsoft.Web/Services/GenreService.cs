using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Data.Repositories;
using TMedsoft.Interfaces;
using TMedsoft.ViewModels;
using TMedsoft.ViewModels.Books;
using TMedsoft.Web.ViewModels.Books;

namespace TMedsoft.Web.Services
{
    public class GenreService : IGenreService
    {
        private readonly GenreRepository _genreRepository;

        public GenreService()
        {
            _genreRepository = new GenreRepository();
        }

        public IEnumerable<ILookup> Get()
        {
            IEnumerable<ILookup> result = new List<Lookup>();
            try
            {
                result = _genreRepository.GetLookup();
            }
            catch (System.Exception ex)
            {
                throw;
            }

            return result;
        }
    }
}