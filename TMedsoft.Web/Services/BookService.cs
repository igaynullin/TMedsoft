using System.Collections.Generic;
using TMedsoft.Data.Entities;
using TMedsoft.Data.Repositories;
using TMedsoft.ViewModels.Books;
using TMedsoft.Web.ViewModels.Books;

namespace TMedsoft.Web.Services
{
    public class BookService : IBookService
    {
        private readonly BookRepository _bookRepository;

        public BookService()
        {
            _bookRepository = new BookRepository();
        }

        public IIndex Get(int pageNumber, int rowsPerPage, long? genreId, string name)
        {
            var result = new Index { Items = new List<IIndexItem>() };
            try
            {
                var entities = _bookRepository.Page(pageNumber, rowsPerPage, genreId, name, out var resultRows);
                foreach (var entity in entities)
                {
                    result.Items.Add(new IndexItem
                    {
                        Name = entity.Name
                        ,
                        Cost = entity.Cost
                        ,
                        GenreName = entity.Genre.Name
                        ,
                        ID = entity.ID.ToString() //protect data
                        ,
                        Quantity = entity.Quantity
                    });
                }
                result.Rows = resultRows;
            }
            catch (System.Exception ex)
            {
                throw;
            }

            return result;
        }
    }
}