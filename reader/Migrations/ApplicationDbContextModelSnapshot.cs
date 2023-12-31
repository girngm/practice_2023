﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace reader2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("reader.ECN", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("H")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("L")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("N")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("ECNs");
                });

            modelBuilder.Entity("reader.Maker", b =>
                {
                    b.Property<int>("MakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MakerId");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("reader.Motor", b =>
                {
                    b.Property<int>("MotorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Freq")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("I")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("L")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("N")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Omega")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Polus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slide")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("T")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TYPE")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("U")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("d")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nju")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("w")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MotorId");

                    b.ToTable("Motors");
                });

            modelBuilder.Entity("reader.SHVN_Nasos", b =>
                {
                    b.Property<int>("SHVN_NasosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dgabarit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Freq")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("H")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hopt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("L")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nju")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("d")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("q100")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SHVN_NasosId");

                    b.ToTable("SHVN_NasosCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
