using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;

namespace TMedsoft.ViewModels
{
    public class ValidateResult : IValidateResult<string, bool>
    {
        public string Result { get; set; }
        public bool State { get; set; }
    }
}