using ExcelOperations.DocEntity;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Context
{
    public class RouterAktuellDbContext : DbContext
    {
        public RouterAktuellDbContext(DbContextOptions<RouterAktuellDbContext> options) : base(options)
        {
        }

        public virtual DbSet<RouterAktuell> RouterAktuell { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //db ayağa kalkarken çalışır oto olarak ekliyor
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RouterAktuellDbContext).Assembly);

            modelBuilder.Entity<RouterAktuell>(i =>
            {
                i.Property<int>("id");
                i.Property<int>("id").ValueGeneratedOnAdd();               
            }
            );

            //modelBuilder.Entity<RouterAktuell>().HasNoKey();

        }
    }
}
