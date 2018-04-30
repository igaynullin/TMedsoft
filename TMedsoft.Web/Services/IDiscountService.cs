using TMedsoft.Web.ViewModels.Cart;

namespace TMedsoft.Web.Services
{
    public interface IDiscountService
    {
        decimal ProcessDiscount(Create viewModel);
    }
}