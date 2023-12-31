﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace reader2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213161244_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ECN", b =>
                {
                    b.Property<int>("ECNId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ECNId");

                    b.ToTable("ECNs");
                });

            modelBuilder.Entity("Maker", b =>
                {
                    b.Property<int>("MakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Adress");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("MakerId");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("Motor", b =>
                {
                    b.Property<int>("MotorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("MotorId");

                    b.ToTable("Motors");
                });

            modelBuilder.Entity("SHVN_Nasos", b =>
                {
                    b.Property<int>("SHVN_NasosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("SHVN_NasosId");

                    b.ToTable("SHVN_NasosCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
