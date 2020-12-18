using ServerApp.Models;

namespace ServerApp.Data.EFCore
{
    public class SupplierRepository : Repository<Supplier, DataContext>
    {
        DataContext _context;
        public SupplierRepository(DataContext context) : base(context)
        {
            _context = context;
        }

    }
}
