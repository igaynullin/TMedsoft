using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TMedsoft.Desktop.Constants;
using TMedsoft.Desktop.Models.Book;
using TMedsoft.ViewModels.Books;

namespace TMedsoft.Desktop.Services
{
    [DataObject(true)]
    public class BookService : IBookService
    {
        private readonly IHttpService _httpService;

        public BookService()

        {
            _httpService = new HttpService();
        }

        public Index Get(int pageNumber, int rowsPerPage, long? genreId, string name)
        {
            var result = new Index { Items = new List<IIndexItem>() };

            try
            {
                var data = _httpService.Get(
                    $"{ApiUrlConstants.root}{ApiUrlConstants.books}?pageNumber={pageNumber}&rowsPerPage={rowsPerPage}&genreId={genreId}&name={name}");
                var json = JObject.Parse(data);
                result.Items.AddRange(json["Items"].ToObject<List<IndexItem>>());

                result.Rows = json["Rows"].ToObject<int>();
            }
            catch (System.Exception ex)
            {
            }
            return result;
        }
    }
}