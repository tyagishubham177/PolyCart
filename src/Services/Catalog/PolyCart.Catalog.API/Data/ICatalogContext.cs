using MongoDB.Driver;
using PolyCart.Catalog.API.Entities;

namespace PolyCart.Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
