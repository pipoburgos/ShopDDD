using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Domain.Products;

namespace Stock.Infrastructure.Products.ConfigurationsEF
{
    // ReSharper disable once InconsistentNaming
    internal class ProductConfigEF : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
