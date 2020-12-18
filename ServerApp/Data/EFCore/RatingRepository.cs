using ServerApp.Models;

namespace ServerApp.Data.EFCore
{
    public class RatingRepository : Repository<Rating, DataContext>
    {
        DataContext _context;
        public RatingRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
