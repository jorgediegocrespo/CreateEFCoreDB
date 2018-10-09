using System;
using System.Collections.Generic;

namespace CreateEFCoreDB.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Order2Product> Order2Products { get; set; }
    }
}
