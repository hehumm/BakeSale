using System.Collections.Generic;
using System.Threading.Tasks;
using BakeSale.Core;
using BakeSale.Data.Domain;

namespace BakeSale.Domain.SalePage
{
    public interface ISalePageRepository : ICrudRepository<IProduct>
    {
        void PurchaseProducts(object o);
    }
}