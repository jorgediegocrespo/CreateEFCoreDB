using CreateEFCoreDB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateEFCoreDB.Config
{
    public class ProductConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Product> entityBuilder)
        {
            //The database table name is 'Products'
            entityBuilder.ToTable("Products");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //A product has many orders
            entityBuilder.HasMany(x => x.Order2Products).WithOne(x => x.Product);
        }
    }
}
