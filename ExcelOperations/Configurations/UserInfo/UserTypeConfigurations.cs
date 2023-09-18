using ExcelOperations.Entities.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.UserInfo
{
    public class UserTypeConfigurations : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
        }
    }
}
