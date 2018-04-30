using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Desktop.Constants;

namespace TMedsoft.Desktop.Services
{
    public class HttpService : IHttpService
    {
        public TModel Get<TModel>(string url, Func<string, TModel> mapper) where TModel : new()
        {
            var result = default(TModel);
            if (mapper == null)
                throw new ArgumentNullException(nameof(mapper));
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = client.GetAsync(url).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = response.Content.ReadAsStringAsync().Result;
                            result = mapper(content);
                        }
                    }
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }
            return result;
        }

        public TModel Post<TModel>(string url, object model, Func<string, TModel> mapper) where TModel : new()
        {
            var result = default(TModel);
            if (mapper == null)
                throw new ArgumentNullException(nameof(mapper));
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));
            try
            {
                using (var client = new HttpClient())
                {
                    string contentType = "application/json";

                    var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, contentType);
                    var response = client.PostAsync(url, content).Result;
                    if (response.IsSuccessStatusCode)

                    {
                        result = mapper(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }
            return result;
        }

        public string Get(string url)
        {
            var result = "";
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = client.GetAsync(url).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            result = response.Content.ReadAsStringAsync().Result;
                        }
                    }
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }
            return result;
        }

        public string Post(string url, object model)
        {
            var result = "";
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));
            try
            {
                using (var client = new HttpClient())
                {
                    string contentType = "application/json";

                    var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, contentType);
                    var response = client.PostAsync(url, content).Result;
                    if (response.IsSuccessStatusCode)

                    {
                        result = response.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }
            return result;
        }
    }
}