using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Entity.Aktuell;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class RouterAktuellConfiguration : IEntityTypeConfiguration<RouterAktuell>
    {
        public void Configure(EntityTypeBuilder<RouterAktuell> builder)
        {
            builder.HasNoKey();
        }
    }
}
