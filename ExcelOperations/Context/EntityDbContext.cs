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
using System.Drawing;

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

            //modelBuilder.Entity<RouterAktuell>(entity =>
            //{
            //    entity
            //    .HasMany<XWDMAktuell>(ra => ra.XWDMAktuells)
            //    .WithMany(xwdm => xwdm.RouterAktuells);
            //});

            #region PrimaryKey

            //modelBuilder.Entity<ProjectIdMapping>(entity =>
            //  {
            //      entity.HasKey(key => key.ProjectId);
            //  });

            //modelBuilder.Entity<SONRMapping>(entity =>
            //{
            //    entity.HasKey(key => key.SoNRId);
            //});

            modelBuilder.Entity<RouterAktuell>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<RouterAktuellOrderList>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<XWDMAktuell>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<XWDMAktuellOrderList>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<LagerCentral>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<Cisco_PO>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<Deltatel_PO>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<ZTE_PO>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<JSLMultiProject>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<MultiProject>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<RouterSwapAktuell>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            modelBuilder.Entity<ZugangsdatenAktuell>(entity =>
            {
                entity.HasKey(key => key.id);
            });

            #endregion PrimaryKey

            #region Mappings
            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.RouterAktuell)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.RouterAktuellId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.RouterAktuellOrderList)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.RouterAktuellOrderListId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.XWDMAktuell)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.XWDMAktuelId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.XWDMAktuellOrderList)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.XWDMAktuelOrderListId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.LagerCentral)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.LagerCentralId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.Cisco_PO)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.CiscoPOId);

            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.Deltatel_PO)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.DeltaTelPOId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.ZTE_PO)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.ZTEPOId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.JSLMultiProject)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.JSLMultiProjectId);

            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.MultiProject)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.MultiProjectId);


            //modelBuilder.Entity<ProjectIdMapping>()
            //    .HasOne(p => p.RouterSwapAktuell)
            //    .WithOne()
            //    .HasForeignKey<ProjectIdMapping>(t => t.RouterSwapAktuellId);


            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.LagerCentral)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.LagerCentralId);

            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.ZTE_PO)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.ZTEPOID);

            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.RouterAktuell)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.RouterAktuellId);

            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.XWDMAktuell)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.XWDMAktuelId);

            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.RouterSwapAktuell)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.RouterSwapAktuellId);

            //modelBuilder.Entity<SONRMapping>()
            //    .HasOne(p => p.ZugangsdatenAktuell)
            //    .WithOne()
            //    .HasForeignKey<SONRMapping>(t => t.ZugansdatenId);
            #endregion Mappings

            modelBuilder.Entity<ZTE_PO>().HasQueryFilter(filter => filter.SO_Nr != null); //querylerde so_nr null olmayanları getiriyor.
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}