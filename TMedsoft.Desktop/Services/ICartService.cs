using TMedsoft.Desktop.Models.Cart;

namespace TMedsoft.Desktop.Services
{
    public interface ICartService
    {
        decimal Create(Create viewModel);
        decimal GetDiscount(Create viewModel);
    }
}