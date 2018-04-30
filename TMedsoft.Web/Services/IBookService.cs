using TMedsoft.ViewModels.Books;

namespace TMedsoft.Web.Services
{
    public interface IBookService
    {
        IIndex Get(int pageNumber, int rowsPerPage, long? genreId, string name);
    }
}