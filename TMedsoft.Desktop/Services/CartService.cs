using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMedsoft.Desktop.Constants;
using TMedsoft.Desktop.Models.Cart;

namespace TMedsoft.Desktop.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpService _httpService;

        public CartService()

        {
            _httpService = new HttpService();
        }

        public decimal GetDiscount(Create viewModel)
        {
            decimal result = 0;
            try
            {
                var data = _httpService.Post($"{ApiUrlConstants.root}{ApiUrlConstants.carts_discount}", viewModel);
                result = JsonConvert.DeserializeObject<decimal>(data);
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return result;
        }

        public decimal Create(Create viewModel)
        {
            decimal result = 0;
            try
            {
                var data = _httpService.Post($"{ApiUrlConstants.root}{ApiUrlConstants.carts}", viewModel);
                result = JsonConvert.DeserializeObject<decimal>(data);
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}