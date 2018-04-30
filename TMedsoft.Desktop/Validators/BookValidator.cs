using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.ViewModels;

namespace TMedsoft.Desktop.Validators
{
    public class BookValidator
    {
        public ValidateResult ValidateQuantity(long quantity, string cartQuantity)
        {
            var result = new ValidateResult
            {
                Result = "",
                State = true
            };
            if (string.IsNullOrEmpty(cartQuantity))
                return result;
            if (long.TryParse(cartQuantity, out var curQuantity) && curQuantity > 0 && curQuantity <= quantity)
                return result;
            else
            {
                result.Result = "Неверный формат данных";
                result.State = false;
            }

            return result;
        }

        public ValidateResult ValidateAddingCartQuantity(long quantity, string cartQuantity, string cartNewQuantity)
        {
            var result = new ValidateResult
            {
                Result = "",
                State = true
            };
            var _quantity = Convert.ToInt64(cartQuantity) + Convert.ToInt64(cartNewQuantity);
            if (quantity <= _quantity || _quantity < 0)
            {
                result.Result = "Большое количество";
                result.State = false;
            }

            return result;
        }
    }
}