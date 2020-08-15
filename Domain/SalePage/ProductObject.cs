using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage
{
    public class ProductObject : IProduct
    {
        public ProductData ProductData { get; }

        public ProductObject(ProductData productData)
        {
            ProductData = productData;
        }
    }
}