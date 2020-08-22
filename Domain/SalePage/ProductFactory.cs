using BakeSale.Core;

namespace BakeSale.Domain.SalePage
{
    public static class ProductFactory
    {
        public static ProductObject Create(
            Product product
            ,Currency currency
            ,Money money
            ,Vendor vendor)
        {
            return new ProductObject(product.Name, money, vendor.Stock[product.Name], null);
        }
    }

}