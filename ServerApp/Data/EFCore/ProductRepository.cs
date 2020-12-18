using ServerApp.Models;

namespace ServerApp.Data.EFCore
{
    public class ProductRepository : Repository<Product, DataContext>
    {
        DataContext _context;
        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
