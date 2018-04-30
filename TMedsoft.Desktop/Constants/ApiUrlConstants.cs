using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Desktop.Constants
{
    public static class ApiUrlConstants
    {
        public static readonly string root = "http://localhost:64686/api/v1/";
        public static readonly string books = "Books";
        public static readonly string genres = "Genres";
        public static readonly string carts = "Carts";
        public static readonly string carts_discount = $"{carts}/Discount";
        public static readonly string genres_lookup = $"{genres}/Lookup";
        public static readonly string orders = "Orders";
    }
}