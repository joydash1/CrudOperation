// <auto-generated />
using BankTransection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankTransection.Migrations
{
    [DbContext(typeof(TransectionDbContext))]
    partial class TransectionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BankTransection.Models.Transection", b =>
                {
                    b.Property<string>("TranstionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BenicifiaryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SwiftCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("TranstionID");

                    b.ToTable("Transections");
                });
#pragma warning restore 612, 618
        }
    }
}
