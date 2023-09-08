using PolyCart.Web.Entities;

namespace PolyCart.Web.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> SendMessage(Contact contact);
        Task<Contact> Subscribe(string address);
    }
}
