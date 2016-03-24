using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using GamesTore.Repository;

namespace GamesTore.Repository.Migrations
{
    [DbContext(typeof(TheaterDbContext))]
    [Migration("20160324230900_Init5")]
    partial class Init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamesTore.Repository.Classes.PriceTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("End");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("Start");

                    b.Property<int?>("TicketId");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.Theater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ManagerId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.TheaterRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SeatsJSON");

                    b.Property<int?>("TheaterId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TheaterId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Role");

                    b.Property<int?>("TheaterId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.PriceTime", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.Theater", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.User")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.TheaterRoom", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.Theater")
                        .WithMany()
                        .HasForeignKey("TheaterId");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.Ticket", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.Theater")
                        .WithMany()
                        .HasForeignKey("TheaterId");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.User", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.Theater")
                        .WithMany()
                        .HasForeignKey("TheaterId");
                });
        }
    }
}
