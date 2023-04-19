using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.DocEntity.UserInfo;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ExcelOperations.Context
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options)
            : base(options)
        {

        }
        
        public virtual DbSet<RouterAktuell>? RouterAktuell { get; set; }
        public virtual DbSet<RouterSwapAktuell>? RouterSwapAktuells { get; set; }
        public virtual DbSet<MultiProject>? MultiProjects { get; set; }
        public virtual DbSet<JSLMultiProject>? JSLMultiProjects { get; set; }
        public virtual DbSet<ZTE_PO>? ZTE_POs { get; set; }
        public virtual DbSet<Deltatel_PO>? Deltatel_POs { get; set; }
        public virtual DbSet<Cisco_PO>? Cisco_POs { get; set; }
        public virtual DbSet<LagerCentral>? LagerCentrals { get; set; }
        public virtual DbSet<ZugangsdatenAktuell>? ZugangsdatenAktuells { get; set; }
        public virtual DbSet<XWDMAktuell>? XWDMAktuells { get; set; }
        public virtual DbSet<XWDMAktuellOrderList>? XWDMAktuelOrderLists { get; set; }
        public virtual DbSet<RouterAktuellOrderList>? RouterAktuellOrderLists { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)  //db ayağa kalkarken çalışır oto olarak ekliyor
        {
            base.OnModelCreating(modelBuilder);             

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);
            
            modelBuilder.Entity<RouterAktuell>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<RouterSwapAktuell>(i =>
            {
                //builder.Property(entity => entity.Id).ValueGeneratedOnAdd();
                //builder.Property(entity => entity.Address).HasColumnName("Zustandige_Region");
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<XWDMAktuell>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<ZugangsdatenAktuell>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<LagerCentral>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<Cisco_PO>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<Deltatel_PO>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<ZTE_PO>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<JSLMultiProject>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<MultiProject>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<UserInput>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );
            
            modelBuilder.Entity<RouterAktuellOrderList>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );
            
            modelBuilder.Entity<XWDMAktuellOrderList>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}