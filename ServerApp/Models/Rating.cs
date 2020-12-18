using ServerApp.Data;

namespace ServerApp.Models
{
    public class Rating : IEntity
    {
        public long Id { get; set; }
        public int Stars { get; set; }
        public Product Product { get; set; }
    }
}
