using PolyCart.Ordering.Application.Models;

namespace PolyCart.Ordering.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
