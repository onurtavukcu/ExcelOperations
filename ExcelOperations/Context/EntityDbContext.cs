using ExcelOperations.Authenticate.AuthenticateOperations;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Entities;
using ExcelOperations.Entities.DocEntity;
using ExcelOperations.Entities.UserInfo;
using ExcelOperations.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Context
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options)
            : base(options)
        {
        }

        #region DbSets
        //public virtual DbSet<ProjectIdMapping> ProjectIdMappings { get; set; }
        //public virtual DbSet<SONRMapping> SONRMappings { get; set; }
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
        public virtual DbSet<User>? UserInputs { get; set; }
        public virtual DbSet<UserType>? UserTypes { get; set; }
        #endregion DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);

            modelBuilder.Entity<UserType>().HasData(
                new UserType
                {
                    id = 1,
                    role = UserTypeEnums.Admin
                },
                new UserType
                {
                    id = 2,
                    role = UserTypeEnums.RegularUser
                }); ;

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Username = "regular",
                    UserTypeId = 1,
                    PasswordHash = PasswordHashingOperations.CreateHash("regular")
                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Username = "admin",
                    UserTypeId = 1,
                    PasswordHash = PasswordHashingOperations.CreateHash("admin")
                }
                );
        }        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}