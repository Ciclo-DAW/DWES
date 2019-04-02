﻿// <auto-generated />
using System;
using GameStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStore.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    partial class GameStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStore.Models.Consola", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime?>("FechaSalida");

                    b.Property<string>("Marca")
                        .HasMaxLength(50);

                    b.Property<string>("Modelo")
                        .HasMaxLength(50);

                    b.Property<float>("Precio");

                    b.HasKey("ID");

                    b.ToTable("Consolas");
                });

            modelBuilder.Entity("GameStore.Models.Juego", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<int>("ConsolaId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime?>("FechaSalida");

                    b.Property<int>("Genero");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50);

                    b.Property<float>("Precio");

                    b.HasKey("ID");

                    b.HasIndex("ConsolaId");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("GameStore.Models.Periferico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<int>("ConsolaId");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime?>("FechaSalida");

                    b.Property<string>("Marca")
                        .HasMaxLength(50);

                    b.Property<string>("Modelo")
                        .HasMaxLength(50);

                    b.Property<float>("Precio");

                    b.Property<int>("Tipo");

                    b.HasKey("ID");

                    b.HasIndex("ConsolaId");

                    b.ToTable("Perifericos");
                });

            modelBuilder.Entity("GameStore.Models.Juego", b =>
                {
                    b.HasOne("GameStore.Models.Consola", "Consola")
                        .WithMany("Juegos")
                        .HasForeignKey("ConsolaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameStore.Models.Periferico", b =>
                {
                    b.HasOne("GameStore.Models.Consola", "Consola")
                        .WithMany("Perifericos")
                        .HasForeignKey("ConsolaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
