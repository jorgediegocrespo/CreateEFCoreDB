using System.Collections.Generic;

namespace CreateEFCoreDB.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
