namespace CreateEFCoreDB.Model
{
    public class Order2Product
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
