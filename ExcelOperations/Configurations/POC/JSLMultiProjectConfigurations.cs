using ExcelOperations.DocEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.POC
{
    public class JSLMultiProjectConfigurations : IEntityTypeConfiguration<JSLMultiProject>
    {
        public void Configure(EntityTypeBuilder<JSLMultiProject> builder)
        {
            builder.HasNoKey();
        }
    }
}
