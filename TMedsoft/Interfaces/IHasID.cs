using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Interfaces
{
    public interface IHasID<T>
    {
        T ID { get; set; }
    }
}