using ExcelOperations.DocEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class XWDMAktuellConfigurations : IEntityTypeConfiguration<XWDMAktuell>
    {
        public void Configure(EntityTypeBuilder<XWDMAktuell> builder)
        {
        }
    }
}

