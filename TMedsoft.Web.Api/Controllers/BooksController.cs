using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using TMedsoft.ViewModels.Books;
using TMedsoft.Web.Services;
using TMedsoft.Web.ViewModels.Books;

namespace TMedsoft.Web.Api.Controllers
{
    public class BooksController : ApiController
    {
        private readonly BookService _bookService;

        public BooksController()
        {
            _bookService = new BookService();
        }

        [HttpGet]
        public IIndex Books(int pageNumber, int rowsPerPage, long? genreId, string name)
        {
            try
            {
                return _bookService.Get(pageNumber, rowsPerPage, genreId, name);
            }
            catch
            {
                throw;
            }
        }
    }
}