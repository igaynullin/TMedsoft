using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;

namespace TMedsoft.ViewModels.Books
{
    public interface IIndex
    {
        List<IIndexItem> Items { get; set; }
        int Rows { get; set; }
    }

    public interface IIndexItem : IHasID<string>, IHasName
    {
        /// <summary>
        /// Fix datagridview
        /// </summary>
        new string ID { get; set; }

        /// <summary>
        /// Fix datagridview
        /// </summary>
        new string Name { get; set; }

        string GenreName { get; set; }
        decimal Cost { get; set; }
        long Quantity { get; set; }
        string CouponCode { get; set; }
    }
}