namespace WebGIS46.Models
{
    public class ProductBL
    {

        public Product[] GetAllProducts()
        {
            return new Product[]
            {
                new Product { Id = 1, Name = "HeadPhone", Price = 19.99m, Description = "Description for Product 1", ImageUrl = "product1.png" },
                new Product { Id = 2, Name = "Keyboard", Price = 29.99m, Description = "Description for Product 2", ImageUrl = "product2.png" },
                new Product { Id = 3, Name = "screen", Price = 39.99m, Description = "Description for Product 3", ImageUrl = "product3.png" }
            };
        }
        public Product GetProductById(int id)
        {
            return GetAllProducts().FirstOrDefault(p => p.Id == id);
        }
    }
}
