using BakeSale.Core;

namespace BakeSale.Domain.SalePage
{
    public interface ISalePageRepository : ICrudRepository<IProduct>
    {
        void PurchaseProducts(object o);
    }
}