using BakeSale.Data.Domain;
using BakeSale.Domain.SalePage;

namespace Infra.SalePage
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