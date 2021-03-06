using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using RenatinhaPlace;

namespace RenatinhaPlace.Migrations
{
    [DbContext(typeof(EntitiesContext))]
    [Migration("20180806210209_crtAll")]
    partial class crtAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RenatinhaPlace.Entity.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtistId");

                    b.Property<int>("ClientId");

                    b.Property<int?>("FuncId");

                    b.Property<string>("Status");

                    b.Property<int>("TicketId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDt");

                    b.Property<string>("Cpf");

                    b.Property<string>("Gen");

                    b.Property<string>("Name");

                    b.Property<decimal>("Pay");

                    b.Property<string>("Rg");

                    b.Property<string>("Sex");

                    b.Property<string>("Tel");

                    b.Property<string>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDt");

                    b.Property<string>("Cpf");

                    b.Property<string>("Name");

                    b.Property<string>("Rg");

                    b.Property<string>("Sex");

                    b.Property<string>("Tel");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("Desc");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("TimeBegin");

                    b.Property<DateTime>("TimeEnd");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Func", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDt");

                    b.Property<string>("Cpf");

                    b.Property<string>("Name");

                    b.Property<string>("Pass");

                    b.Property<string>("Rg");

                    b.Property<string>("Sex");

                    b.Property<string>("Tel");

                    b.Property<int>("TypeId");

                    b.Property<string>("User");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.FuncType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Access");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.ItemAcc", b =>
                {
                    b.Property<int>("AccountId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Qnt");

                    b.HasKey("AccountId", "ProductId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.ItemMenu", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("MenuId");

                    b.HasKey("ProductId", "MenuId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.Property<decimal>("PriceUni");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Type");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Account", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("RenatinhaPlace.Entity.Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("RenatinhaPlace.Entity.Func")
                        .WithMany()
                        .HasForeignKey("FuncId");

                    b.HasOne("RenatinhaPlace.Entity.Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Event", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("RenatinhaPlace.Entity.Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Func", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.FuncType")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.ItemAcc", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("RenatinhaPlace.Entity.Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.ItemMenu", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");

                    b.HasOne("RenatinhaPlace.Entity.Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("RenatinhaPlace.Entity.Ticket", b =>
                {
                    b.HasOne("RenatinhaPlace.Entity.Event")
                        .WithMany()
                        .HasForeignKey("EventId");
                });
        }
    }
}
