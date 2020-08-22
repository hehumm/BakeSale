using BakeSale.Core;

namespace BakeSale.Domain.SalePage
{
    public class ProductObject : IProduct
    {
        public string Name { get; }
        public Money Price { get; }
        public int Stock { get; }
        public byte[] Image { get; }

        public ProductObject(string name, Money price, int stock, byte[] image)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}