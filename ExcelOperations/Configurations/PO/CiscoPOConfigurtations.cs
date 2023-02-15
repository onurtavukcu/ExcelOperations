using ExcelOperations.DocEntity.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.PO
{
    public class CiscoPOConfigurtations : IEntityTypeConfiguration<Cisco_PO>
    {
        public void Configure(EntityTypeBuilder<Cisco_PO> builder)
        {
        }
    }
}
