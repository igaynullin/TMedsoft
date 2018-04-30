using System.Collections.Generic;
using TMedsoft.Interfaces;

namespace TMedsoft.Web.Services
{
    public interface IGenreService
    {
        IEnumerable<ILookup> Get();
    }
}