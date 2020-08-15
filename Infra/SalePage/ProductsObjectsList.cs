using System.Collections.Generic;
using BakeSale.Data.Domain;

namespace Infra.SalePage
{
    public class ProductsObjectsList : List<ProductObject>
    {
        public ProductsObjectsList(IEnumerable<ProductData> productData)
        {
            foreach (var data in productData)
            {
                Add(ProductFactory.Create(
                    data.Id,
                    data.Name,
                    data.PriceId,
                    data.Image));
            }
        }
    }
}