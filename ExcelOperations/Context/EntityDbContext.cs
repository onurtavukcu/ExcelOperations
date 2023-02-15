﻿using ExcelOperations.Doc.Entity.POC;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Lager;
using ExcelOperations.DocEntity.PO;
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
        public virtual DbSet<MultiProject>? XWDMAktuells { get; set; }
        public virtual DbSet<JSLMultiProject>? JSLMultiProjects { get; set; }
        public virtual DbSet<ZTE_PO>? ZTE_POs{ get; set; }
        public virtual DbSet<Deltatel_PO>? Deltatel_POs{ get; set; }
        public virtual DbSet<Cisco_PO>? Cisco_POs { get; set; }
        public virtual DbSet<Depo>? Depos { get; set; }
        public virtual DbSet<ZugangsdatenAktuell>? ZugangsdatenAktuells{ get; set; }
        public virtual DbSet<XWDMAktuell>? XWDMAktuells{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //db ayağa kalkarken çalışır oto olarak ekliyor
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityDbContext).Assembly);

            modelBuilder.Entity<RouterAktuell>(i =>
            {
                i.Property<int>("id").ValueGeneratedOnAdd();
            }
            );

            modelBuilder.Entity<RouterSwapAktuell>(i =>
            {
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

            modelBuilder.Entity<Depo>(i =>
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
        }
    }
}