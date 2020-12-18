using Microsoft.AspNetCore.Mvc;
using ServerApp.Data.EFCore;
using ServerApp.Models;


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
      
    }
}
