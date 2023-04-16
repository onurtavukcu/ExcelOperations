using ExcelOperations.DocEntity.Entity.Lager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.Lagers
{
    public class LagersConfigurations : IEntityTypeConfiguration<LagerCentral>
    {
        public void Configure(EntityTypeBuilder<LagerCentral> builder)
        {
        }
    }
}