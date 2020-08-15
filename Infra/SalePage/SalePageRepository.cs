using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeSale.Data.Domain;
using BakeSale.Domain.SalePage;
using Microsoft.EntityFrameworkCore;

namespace Infra.SalePage
{
    //Todo
    public class SalePageRepository : ISalePageRepository
    {
        private readonly BakeSaleDbContext _context;
        public List<ProductData> ProductDataList { get; set; }

        public SalePageRepository(BakeSaleDbContext context)
        {
            this._context = context;
            ProductDataList = _context.Products.ToList();
        }

        public async Task<IProduct> GetObject(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IProduct>> GetObjectsList()
        {
            var data = await _context.Products.ToListAsync();
            return new ProductsObjectsList(data);
        }

        public async Task<IProduct> AddObject(IProduct shipmentObject)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateObject(IProduct shipmentObject)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteObject(IProduct o)
        {
            throw new NotImplementedException();
        }

        public void PurchaseProducts(object o)
        {
            throw new System.NotImplementedException();
        }

        private IQueryable<ProductData> QueryDb()
        {
            IQueryable<ProductData> incomingShipments = from s in _context.Products select s;
            throw new System.NotImplementedException();
        }

        public int PageIndex { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
    }
}