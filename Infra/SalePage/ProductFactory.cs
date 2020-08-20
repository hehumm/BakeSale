using System;
using System.Collections.Generic;
using BakeSale.Core;
using BakeSale.Data.Core;
using BakeSale.Data.Domain;

namespace Infra.SalePage
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