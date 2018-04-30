using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Desktop.Services
{
    internal interface IHttpService
    {
        TModel Get<TModel>(string url, Func<string, TModel> mapper) where TModel : new();

        TModel Post<TModel>(string url, object model, Func<string, TModel> mapper) where TModel : new();

        string Get(string url);

        string Post(string url, object model);
    }
}