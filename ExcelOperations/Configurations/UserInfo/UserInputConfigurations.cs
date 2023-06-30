using ExcelOperations.DocEntity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.UserInfo
{
    public class UserInputConfigurations : IEntityTypeConfiguration<UserInput>
    {
        public void Configure(EntityTypeBuilder<UserInput> builder)
        {
            builder.HasNoKey();
        }
    }
}
