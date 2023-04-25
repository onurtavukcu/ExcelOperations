using ExcelOperations.DocEntity.Entity.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class ZTEPOConfigurations : IEntityTypeConfiguration<ZTE_PO>
    {
        public void Configure(EntityTypeBuilder<ZTE_PO> builder)
        {
            builder.HasNoKey();
        }
    }
}
