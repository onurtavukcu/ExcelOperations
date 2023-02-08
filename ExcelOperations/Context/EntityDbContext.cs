using ExcelOperations.DocEntity;
using Microsoft.EntityFrameworkCore;


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

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //db ayağa kalkarken çalışır oto olarak ekliyor
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);

            modelBuilder.Entity<RouterAktuell>(i =>
            {
                i.Property<int>("id");
                i.Property<int>("id").ValueGeneratedOnAdd();               
            }
            );

            modelBuilder.Entity<RouterSwapAktuell>(i =>
            {
                i.Property<int>("id");
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );
        }
    }
}
