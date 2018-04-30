using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TMedsoft.Interfaces;
using TMedsoft.Web.Services;
using TMedsoft.Web.ViewModels.Cart;

namespace TMedsoft.Web.Api.Controllers
{
    public class CartsController : ApiController
    {
        private readonly DiscountService _discountService;
        //private readonly OrderService _orderService;

        public CartsController()
        {
            _discountService = new DiscountService();
            //_orderService = new OrderService();
        }

        [HttpPost]
        public decimal Post(Create viewModel)
        {
            return _discountService.ProcessDiscount(viewModel);
        }

        [ActionName("Discount")]
        public decimal Discount(Create viewModel)
        {
            return _discountService.ProcessDiscount(viewModel);
        }
    }
}