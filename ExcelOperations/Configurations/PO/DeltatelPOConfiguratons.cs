using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class DeltatelPOConfiguratons : IEntityTypeConfiguration<Deltatel_PO>
    {
        public void Configure(EntityTypeBuilder<Deltatel_PO> builder)
        {
            builder.HasNoKey();
        }
    }
}
