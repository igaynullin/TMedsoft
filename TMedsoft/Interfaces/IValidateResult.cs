using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Interfaces
{
    public interface IValidateResult<TResult, TState> : IResult<TResult>, IState<TState>
    {
    }
}