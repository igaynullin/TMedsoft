using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Data.Entities;
using TMedsoft.Data.Repositories;
using TMedsoft.Web.ViewModels.Cart;

namespace TMedsoft.Web.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public void Create(Create viewModel)
        {
            var order = new Order
            {
            };
        }
    }
}