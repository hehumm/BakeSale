using System;
using BakeSale.Domain.SalePage;
using Microsoft.AspNetCore.Mvc;

namespace BakeSale.BakeSaleApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISalePageRepository _repository;

        public ProductsController(ISalePageRepository repository)
        {
            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _repository.GetObjectsList().Result;
            var jsonFormat = new JsonResult(products);
            //return jsonFormat;
            return jsonFormat;
        }
    }
}
