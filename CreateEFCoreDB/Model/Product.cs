using System.Collections.Generic;

namespace CreateEFCoreDB.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<Order2Product> Order2Products { get; set; }
    }
}
