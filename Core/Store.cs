using System.Net.Http.Headers;
using Core.Domain;

namespace Core
{
    public class Store
    {
        public Store()
        {
            Products = new List<Product>()
            {
                new Product(){
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Coust = 100,
                    Key = "Key 1"
                }
            };
        }

        public List<Product> Products { get; set; }
    }

}