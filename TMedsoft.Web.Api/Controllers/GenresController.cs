using TMedsoft.Interfaces;
using System.Web.Http;
using TMedsoft.Web.Services;
using System.Collections.Generic;
using System.Web.Http.Description;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace TMedsoft.Web.Api.Controllers
{
    public class GenresController : ApiController
    {
        private readonly GenreService _bookService;

        public GenresController()
        {
            _bookService = new GenreService();
        }

        [ActionName("Lookup")]
        public IEnumerable<ILookup> GetLookup()
        {
            return _bookService.Get();
        }
    }
}