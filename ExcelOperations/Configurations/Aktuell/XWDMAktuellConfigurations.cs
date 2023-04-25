using ExcelOperations.DocEntity.Entity.Aktuell;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class XWDMAktuellConfigurations : IEntityTypeConfiguration<XWDMAktuell>
    {
        public void Configure(EntityTypeBuilder<XWDMAktuell> builder)
        {
            builder.HasNoKey();
        }
    }
}

