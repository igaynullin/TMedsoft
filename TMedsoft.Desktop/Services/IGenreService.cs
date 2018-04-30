using System.Collections.Generic;
using TMedsoft.Interfaces;

namespace TMedsoft.Desktop.Services
{
    public interface IGenreService
    {
        IEnumerable<ILookup> GetLookup();
    }
}