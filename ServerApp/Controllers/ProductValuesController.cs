using Microsoft.AspNetCore.Mvc;
using ServerApp.Data.EFCore;
using ServerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductValuesController : AppController<Product, ProductRepository>
    {
        ProductRepository _repository;
        public ProductValuesController(ProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [HttpGet("rel")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(string category, string search, 
            bool related = false)
        {
            return await _repository.GetWithRelated(category, search, related);
        }
    }


}
