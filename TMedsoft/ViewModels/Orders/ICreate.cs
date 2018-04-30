using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;

namespace TMedsoft.ViewModels.Orders
{
    public interface ICreate
    {
        List<ICreateItem> Items { get; set; }
    }

    public interface ICreateItem : IHasID<string>
    {
        long Quanity { get; set; }
    }
}