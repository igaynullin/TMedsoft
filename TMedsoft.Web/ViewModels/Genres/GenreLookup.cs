using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMedsoft.Interfaces;

namespace TMedsoft.Web.ViewModels.Genres
{
    public class GenreLookup : ILookup
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}