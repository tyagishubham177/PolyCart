using MongoDB.Driver;
using PolyCart.Catalog.API.Entities;

namespace PolyCart.Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "iPhone 13 Pro Max",
                    Summary = "Apple's latest powerhouse with A15 Bionic chip and ProMotion display.",
                    Description = "With up to 1TB storage, a stunning 120Hz ProMotion display, and triple-camera setup featuring ProRAW, the iPhone 13 Pro Max is Apple's most advanced smartphone yet.",
                    ImageFile = "product-1.png",
                    Price = 1099.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung Galaxy S21 Ultra",
                    Summary = "Samsung's flagship offering with Exynos 2100/Snapdragon 888 and up to 100x zoom.",
                    Description = "Samsung Galaxy S21 Ultra offers a versatile quad-camera setup, up to 16GB RAM, and supports the S Pen. A dynamic AMOLED 2X screen makes it ideal for both work and play.",
                    ImageFile = "product-2.png",
                    Price = 1199.99M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Google Pixel 6 Pro",
                    Summary = "Google's AI-first approach in a phone, featuring the custom-built Tensor chip.",
                    Description = "With Google's custom Tensor SOC, improved dual-camera setup with Magic Eraser, and Real Tone technology for natural skin color, the Pixel 6 Pro is Google's most impressive phone yet.",
                    ImageFile = "product-3.png",
                    Price = 899.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "OnePlus 9 Pro",
                    Summary = "Speedy performance meets Hasselblad partnership for color accuracy.",
                    Description = "OnePlus 9 Pro offers a smooth 120Hz AMOLED display, Snapdragon 888, and a camera system co-developed with Hasselblad for stunning color accuracy and detail.",
                    ImageFile = "product-4.png",
                    Price = 969.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Xiaomi Mi 11 Ultra",
                    Summary = "Packing a secondary rear display and an impressive 50MP main sensor.",
                    Description = "Xiaomi Mi 11 Ultra features a 120Hz QHD+ display, Snapdragon 888, and a unique secondary display next to the camera module. Top-of-the-line camera sensors make it a photo enthusiast's dream.",
                    ImageFile = "product-5.png",
                    Price = 999.99M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "Sony Xperia 1 III",
                    Summary = "A phone for the multimedia enthusiast with a 4K 120Hz display.",
                    Description = "With a 4K 120Hz display, the Xperia 1 III is aimed at users who consume a lot of video content. The phone also offers robust manual controls for both photo and video capturing.",
                    ImageFile = "product-6.png",
                    Price = 1299.99M,
                    Category = "Smart Phone"
                }
            };
        }
    }
}