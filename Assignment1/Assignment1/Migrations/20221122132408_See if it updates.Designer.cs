﻿// <auto-generated />
using Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221122132408_See if it updates")]
    partial class Seeifitupdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Assignment1.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Göteborg",
                            CountryId = 1
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Stockholm",
                            CountryId = 1
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Sweden"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonId = "7eb42585-98da-46f3-b498-2e8a53c5fed3",
                            CityId = 1,
                            Name = "Niklas Bergh",
                            Phone = "031-123456"
                        },
                        new
                        {
                            PersonId = "b3585a61-e856-4be5-adb6-0488b71b4962",
                            CityId = 2,
                            Name = "Greger Puff",
                            Phone = "031-666666"
                        },
                        new
                        {
                            PersonId = "4f4ef7ef-649b-4a03-8b23-1d4ccaebb488",
                            CityId = 2,
                            Name = "The Dude",
                            Phone = "0707985544"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.City", b =>
                {
                    b.HasOne("Assignment1.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Assignment1.Models.Person", b =>
                {
                    b.HasOne("Assignment1.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Assignment1.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("Assignment1.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
