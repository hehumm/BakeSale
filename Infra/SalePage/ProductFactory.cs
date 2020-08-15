using BakeSale.Data.Domain;

namespace Infra.SalePage
{
    public class ProductFactory
    {
        public static ProductObject Create(
            string id,
            string name,
            string priceId,
            byte[] image)
        {
            var productData = new ProductData()
            {
                Id = id,
                Name = name,
                PriceId = priceId,
                Image = image
            };
            return new ProductObject(productData);
        }
    }
}