using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TMedsoft.Interfaces
{
    public interface ILookup
    {
        string Text { get; set; }
        string Value { get; set; }
    }
}