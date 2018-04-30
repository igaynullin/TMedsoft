using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;

namespace TMedsoft.ViewModels
{
    public class Lookup : ILookup
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}