
using Product.API.Entities;
using ILogger = Serilog.ILogger;

namespace Product.API.Persistence
{
    public class ProductContextSeed
    {
        public static async Task SeedProductAsync(ProductContext productContext, ILogger logger)
        {
            if (!productContext.Products.Any())
            {
                productContext.AddRange(getCatalogProducts());
                await productContext.SaveChangesAsync();
                logger.Information("Seeded data for Product DB associated with context {DbContextName}", nameof(ProductContext));
            }
        }

        private static IEnumerable<CatalogProduct> getCatalogProducts()
        {
            return new List<CatalogProduct>
            {
                new()
                {
                    //Hãy tạo ra dữ liệu mẫu cho CatalogProduct
                    //và gán các giá trị vào các trường tương ứng
                    No = "Cup",
                    Name = "Cup",
                    Price = (decimal)10.99,
                    Description = "Cup",
                    Summary = "Cup",
                },
                //Thêm các dữ liệu mẫu khác
                new()
                {
                    No = "Plate",
                    Name = "Plate",
                    Price = (decimal)15.99,
                    Description = "Plate",
                    Summary = "Plate",
                }
            };  
        }
    }
}
