using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMedsoft.Desktop.Constants;
using TMedsoft.Desktop.Models.Book;
using TMedsoft.Interfaces;
using TMedsoft.ViewModels;

namespace TMedsoft.Desktop.Services
{
    [DataObject(true)]
    public class GenreService : IGenreService
    {
        private readonly IHttpService _httpService;

        public GenreService()

        {
            _httpService = new HttpService();
        }

        public IEnumerable<ILookup> GetLookup()
        {
            var result = new List<ILookup>();
            try
            {
                var data = _httpService.Get($"{ApiUrlConstants.root}{ApiUrlConstants.genres_lookup}");

                result.AddRange(JsonConvert.DeserializeObject<List<Lookup>>(data));
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}