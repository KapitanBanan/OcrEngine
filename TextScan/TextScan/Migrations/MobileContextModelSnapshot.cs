using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TextScan;

namespace TextScan.Migrations
{
    [DbContext(typeof(MobileContext))]
    partial class MobileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TextScan.Costs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<float>("Total");

                    b.HasKey("Id");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("TextScan.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CostsId");

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CostsId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("TextScan.Product", b =>
                {
                    b.HasOne("TextScan.Costs", "Costs")
                        .WithMany("Products")
                        .HasForeignKey("CostsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
