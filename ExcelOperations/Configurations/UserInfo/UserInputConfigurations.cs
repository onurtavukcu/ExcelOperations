using ExcelOperations.DocEntity.UserInfo;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Configurations.UserInfo
{
    public class UserInputConfigurations : IEntityTypeConfiguration<UserInput>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserInput> builder)
        {
            builder.HasNoKey();
        }
    }
}
