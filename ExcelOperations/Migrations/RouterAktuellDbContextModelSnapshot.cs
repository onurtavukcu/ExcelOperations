﻿// <auto-generated />
using ExcelOperations.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExcelOperations.Migrations
{
    [DbContext(typeof(RouterAktuellDbContext))]
    partial class RouterAktuellDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExcelOperations.DocEntity.RouterAktuell", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Alt")
                        .HasColumnType("text");

                    b.Property<string>("Anz_NE30")
                        .HasColumnType("text");

                    b.Property<string>("Anz_NE31")
                        .HasColumnType("text");

                    b.Property<string>("Anz_NE32")
                        .HasColumnType("text");

                    b.Property<string>("Anz_NE33")
                        .HasColumnType("text");

                    b.Property<string>("Bezeichnung")
                        .HasColumnType("text");

                    b.Property<string>("CtK_Status")
                        .HasColumnType("text");

                    b.Property<string>("DF")
                        .HasColumnType("text");

                    b.Property<string>("DF_1st_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("DF_Ist")
                        .HasColumnType("text");

                    b.Property<string>("Demand")
                        .HasColumnType("text");

                    b.Property<string>("Dim_Beauftragungsform")
                        .HasColumnType("text");

                    b.Property<string>("Dim_OSPF")
                        .HasColumnType("text");

                    b.Property<string>("Dim_POC_Projekt")
                        .HasColumnType("text");

                    b.Property<string>("Dim_Squads")
                        .HasColumnType("text");

                    b.Property<string>("Eigentumer")
                        .HasColumnType("text");

                    b.Property<string>("Festnetzplaner")
                        .HasColumnType("text");

                    b.Property<string>("GU_Projekt")
                        .HasColumnType("text");

                    b.Property<string>("GU_Transport")
                        .HasColumnType("text");

                    b.Property<string>("Gebaudeart")
                        .HasColumnType("text");

                    b.Property<string>("Infrastruktur_Soll_Baseframe_Radio_MW")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx11")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx18b")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx29b")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx29t")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx29y")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx29z")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx30")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx30n")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx30o")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx30p")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx40")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx40Stern")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx43")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx43a")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx43c")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx44")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx51a")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx51b")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx51r")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx52b")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx52n")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx52p")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx53")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx59")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx59k")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx60")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx62a")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx62g")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx62j")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx62r")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx62w")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx68n")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx68o")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx68p")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx71")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx71a")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx71b")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx71c")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx80")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx87r")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx88i")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx89")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx91")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx91c")
                        .HasColumnType("text");

                    b.Property<string>("Ist_Stx91r")
                        .HasColumnType("text");

                    b.Property<string>("Kol_NE78_MxMS")
                        .HasColumnType("text");

                    b.Property<string>("LL")
                        .HasColumnType("text");

                    b.Property<string>("LL_1st_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("LL_Ist")
                        .HasColumnType("text");

                    b.Property<string>("MP_POC")
                        .HasColumnType("text");

                    b.Property<string>("MW")
                        .HasColumnType("text");

                    b.Property<string>("MW_1st_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("MW_Ist")
                        .HasColumnType("text");

                    b.Property<string>("NE_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("NE_Name")
                        .HasColumnType("text");

                    b.Property<string>("NE_Nr")
                        .HasColumnType("text");

                    b.Property<string>("NE_Nr_EPlus")
                        .HasColumnType("text");

                    b.Property<string>("NRG_Transition")
                        .HasColumnType("text");

                    b.Property<string>("Ort")
                        .HasColumnType("text");

                    b.Property<string>("PLZ")
                        .HasColumnType("text");

                    b.Property<string>("POC_Projekt")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx40")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx59")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx59k")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx62g")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx62j")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx68n")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx68p")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx71")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx88i")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("Plan_Stx91")
                        .HasColumnType("text");

                    b.Property<string>("Projekt_Equipment")
                        .HasColumnType("text");

                    b.Property<string>("Projekt_ID")
                        .HasColumnType("text");

                    b.Property<string>("Projektart")
                        .HasColumnType("text");

                    b.Property<string>("Projektbemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Projektstand")
                        .HasColumnType("text");

                    b.Property<string>("SAT")
                        .HasColumnType("text");

                    b.Property<string>("SAT_1st_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("SAT_Ist")
                        .HasColumnType("text");

                    b.Property<string>("SONumber")
                        .HasColumnType("text");

                    b.Property<string>("SO_Nr_EPlus")
                        .HasColumnType("text");

                    b.Property<string>("SWD_POC_Sourcing")
                        .HasColumnType("text");

                    b.Property<string>("Soll_Stx62j")
                        .HasColumnType("text");

                    b.Property<string>("Soll_Stx71")
                        .HasColumnType("text");

                    b.Property<string>("Soll_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("Strasse")
                        .HasColumnType("text");

                    b.Property<string>("Stx11_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx29t_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx29z_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx30_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx30n_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx30p_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx40_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx43a_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx44_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx51b_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx51r_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx52b_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx52n_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx52p_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx53_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx59_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx59k_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx60_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx62a_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx62g_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx62j_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx62w_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx68n_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx68p_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx71_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx71b_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx71c_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx80_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx88i_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx90_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("Stx91_Bemerkung")
                        .HasColumnType("text");

                    b.Property<string>("TOM_EXECUTION")
                        .HasColumnType("text");

                    b.Property<string>("TOM_PLANNING_PREPARATION")
                        .HasColumnType("text");

                    b.Property<string>("Template_Bezeichnung")
                        .HasColumnType("text");

                    b.Property<string>("UTS_Ticket_am_Projekt")
                        .HasColumnType("text");

                    b.Property<string>("Verantw_Organisationseinheit")
                        .HasColumnType("text");

                    b.Property<string>("WL")
                        .HasColumnType("text");

                    b.Property<string>("WL_1st_Stx90")
                        .HasColumnType("text");

                    b.Property<string>("WL_Ist")
                        .HasColumnType("text");

                    b.Property<string>("Ziel_des_Projekts")
                        .HasColumnType("text");

                    b.Property<string>("ZustandigeRegion")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("RouterAktuell");
                });
#pragma warning restore 612, 618
        }
    }
}
