using CreateEFCoreDB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateEFCoreDB.Config
{
    public class OrderConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Order> entityBuilder)
        {
            //The database table name is 'Orders'
            entityBuilder.ToTable("Orders");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //An order has one customer and many products
            entityBuilder.HasOne(x => x.Customer).WithMany(x => x.Orders);
            entityBuilder.HasMany(x => x.Order2Products).WithOne(x => x.Order);
        }
    }
}
