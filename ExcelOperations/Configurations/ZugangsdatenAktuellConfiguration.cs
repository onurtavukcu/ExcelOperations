﻿using ExcelOperations.DocEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExcelOperations.Configurations
{
    public class ZugangsdatenAktuellConfiguration : IEntityTypeConfiguration<ZugangsdatenAktuell>
    {
        public void Configure(EntityTypeBuilder<ZugangsdatenAktuell> builder)
        {
        }
    }
}