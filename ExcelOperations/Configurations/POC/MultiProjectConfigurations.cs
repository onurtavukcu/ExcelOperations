using ExcelOperations.Doc.Entity.POC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.POC
{
    public class MultiProjectConfigurations : IEntityTypeConfiguration<MultiProject>
    {
        public void Configure(EntityTypeBuilder<MultiProject> builder)
        {
        }
    }
}
