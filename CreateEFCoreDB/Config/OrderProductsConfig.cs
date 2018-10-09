using CreateEFCoreDB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateEFCoreDB.Config
{
    public class OrderProductsConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Order2Product> entityBuilder)
        {
            //The database table name is 'Order2Product'
            entityBuilder.ToTable("Order2Product");

            //OrderId and ProductId are requiered and they´re the primary key
            entityBuilder.HasKey(x => new { x.OrderId, x.ProductId });
            entityBuilder.Property(x => x.OrderId).IsRequired();
            entityBuilder.Property(x => x.ProductId).IsRequired();

            //An customer has one customer and many products
            entityBuilder.HasOne(x => x.Product).WithMany(x => x.Order2Products);
            entityBuilder.HasOne(x => x.Order).WithMany(x => x.Order2Products);
        }
    }
}
