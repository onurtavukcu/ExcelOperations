﻿using ExcelOperations.DocEntity.Entity.POC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class RouterSwapAktuellConfiguration : IEntityTypeConfiguration<RouterSwapAktuell>
    {
        public void Configure(EntityTypeBuilder<RouterSwapAktuell> builder)
        {
        }
    }
}
