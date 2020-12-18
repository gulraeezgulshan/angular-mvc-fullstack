using ServerApp.Data;
using System.Collections.Generic;

namespace ServerApp.Models
{
    public class Supplier : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
