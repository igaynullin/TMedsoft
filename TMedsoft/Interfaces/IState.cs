using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Interfaces
{
    public interface IState<TState>
    {
        TState State { get; set; }
    }
}