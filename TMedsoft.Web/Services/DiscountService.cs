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
    public class DiscountService : IDiscountService
    {
        private readonly DiscountRepository _discountRepository;

        private readonly BookRepository _bookRepository;

        public DiscountService()
        {
            _discountRepository = new DiscountRepository();
            _bookRepository = new BookRepository();
        }

        public decimal ProcessDiscount(Create viewModel)
        {
            decimal discountSum = 0;
            IEnumerable<Book> books = null;
            List<Book> _cartBooks = new List<Book>();
            IEnumerable<Discount> discounts = null;
            List<long> ids = new List<long>();
            if (viewModel.Items != null && viewModel.Items.Count > 0)
            {
                foreach (var item in viewModel.Items)
                {
                    var temp = new Book { ID = Convert.ToInt64(item.ID), Quantity = item.Quantity, Cost = item.Cost, GenreID = item.GenreID };
                    ids.Add(temp.ID);
                    _cartBooks.Add(temp);
                }

                books = _bookRepository.Select(ids);
                foreach (var book in books)
                {
                    var item = _cartBooks.FirstOrDefault(e => e.ID == book.ID);
                    item.Cost = book.Cost;
                }
                discounts = _discountRepository.Get();
            }
            decimal totalCost = 0;
            if (!string.IsNullOrEmpty(viewModel.CouponCode))
            {
                discountSum = DiscountOrderSum(viewModel.CouponCode, discounts, _cartBooks, totalCost, discountSum);
            }
            else
            {
                discountSum = DiscountGenreSum(discounts, _cartBooks, discountSum);
                if (discountSum == 0)
                {
                    discountSum = DiscountBookSum(discounts, _cartBooks, discountSum);
                }
            }
            return discountSum;
        }

        private decimal DiscountBookSum(IEnumerable<Discount> discounts, List<Book> _cartBooks, decimal discountSum)
        {
            foreach (var discount in discounts)
            {
                foreach (var discountBook in discount.DiscountBooks)
                {
                    var _books = _cartBooks.Where(e => e.ID == discountBook);
                    if (_books.Any() && discount.BookRequired == _books.Count())
                    {
                        discountSum += discount.Percentage / 100 * _books.Sum(e => e.Cost * e.Quantity);
                    }
                }
            }
            return discountSum;
        }

        private decimal DiscountGenreSum(IEnumerable<Discount> discounts, List<Book> _cartBooks, decimal discountSum)
        {
            foreach (var discount in discounts)
            {
                foreach (var discountGenre in discount.DiscountGenres)
                {
                    var genreBooks = _cartBooks.Where(e => e.GenreID == discountGenre);

                    if (genreBooks.Any() && discount.BookRequired == genreBooks.Count())
                    {
                        discountSum += discount.Percentage / 100 * genreBooks.Sum(e => e.Cost * e.Quantity);
                    }
                }
            }
            return discountSum;
        }

        private decimal DiscountOrderSum(string couponCode, IEnumerable<Discount> discounts, List<Book> _cartBooks, decimal totalCost,
            decimal discountSum)
        {
            var discount = discounts.FirstOrDefault(e =>
                e.TypeDiscount == TypeDiscount.OrderDiscount && e.CouponCode == couponCode);
            if (discount != null && discount.BookRequired == _cartBooks.Count)
            {
                foreach (var item in _cartBooks)
                {
                    totalCost += item.Cost * item.Quantity;
                }
                discountSum = discount.Percentage / 100 * totalCost;
            }
            return discountSum;
        }
    }
}