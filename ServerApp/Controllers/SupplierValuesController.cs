using Microsoft.AspNetCore.Mvc;
using ServerApp.Data.EFCore;
using ServerApp.Models;

namespace ServerApp.Controllers
{

    [Route("api/suppliers")]
    [ApiController]
    public class SupplierValuesController : AppController<Supplier, SupplierRepository>
    {
        SupplierRepository _repository;
        public SupplierValuesController(SupplierRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}

