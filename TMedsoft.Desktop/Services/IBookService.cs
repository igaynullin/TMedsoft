using TMedsoft.Desktop.Models.Book;

namespace TMedsoft.Desktop.Services
{
    public interface IBookService
    {
        Index Get(int pageNumber, int rowsPerPage, long? genreId, string name);
    }
}