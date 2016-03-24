using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using GamesTore.Repository;

namespace GamesTore.Repository.Migrations
{
    [DbContext(typeof(TheaterDbContext))]
    [Migration("20160324230302_Init3")]
    partial class Init3
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

            modelBuilder.Entity("GamesTore.Repository.Classes.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Role");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GamesTore.Repository.Classes.PriceTime", b =>
                {
                    b.HasOne("GamesTore.Repository.Classes.Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");
                });
        }
    }
}
