using ExcelOperations.DocEntity.Aktuell;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations.Aktuell
{
    public class RouterAktuellOrderListConfiguration : IEntityTypeConfiguration<RouterAktuellOrderList>
    {
        public void Configure(EntityTypeBuilder<RouterAktuellOrderList> builder)
        {
        }
    }
}
