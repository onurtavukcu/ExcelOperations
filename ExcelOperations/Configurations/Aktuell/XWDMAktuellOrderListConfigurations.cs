using ExcelOperations.DocEntity.Aktuell;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.Aktuell
{
    public class XWDMAktuellOrderListConfigurations : IEntityTypeConfiguration<XWDMAktuellOrderList>
    {
        public void Configure(EntityTypeBuilder<XWDMAktuellOrderList> builder)
        {
        }
    }
}
