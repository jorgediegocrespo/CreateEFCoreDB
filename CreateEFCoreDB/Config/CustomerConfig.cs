using CreateEFCoreDB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateEFCoreDB.Config
{
    public class CustomerConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Customer> entityBuilder)
        {
            //The database table name is 'Customers'
            entityBuilder.ToTable("Customers");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //A customer has many orders
            entityBuilder.HasMany(x => x.Orders).WithOne(x => x.Customer);
        }
    }
}
