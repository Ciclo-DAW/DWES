﻿// <auto-generated />
using System;
using Concesionario_UD6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Concesionario_UD6.Migrations
{
    [DbContext(typeof(ConcesionarioContext))]
    [Migration("20190326004737_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Concesionario_UD6.Models.Concesionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.HasKey("ID");

                    b.ToTable("Concesionarios");
                });

            modelBuilder.Entity("Concesionario_UD6.Models.Ubicacion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("Concesionario_UD6.Models.Vehiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Combustible");

                    b.Property<int>("ConcesionarioId");

                    b.Property<DateTime?>("DataRecepcion");

                    b.Property<DateTime?>("DataVenta");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<string>("Marca")
                        .HasMaxLength(60);

                    b.Property<string>("Modelo")
                        .HasMaxLength(60);

                    b.Property<string>("NumBastidor");

                    b.Property<int>("TipoVehiculo");

                    b.Property<int>("UbicacionId");

                    b.HasKey("ID");

                    b.HasIndex("ConcesionarioId");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Concesionario_UD6.Models.Vehiculo", b =>
                {
                    b.HasOne("Concesionario_UD6.Models.Concesionario", "Concesionario")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ConcesionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Concesionario_UD6.Models.Ubicacion", "Ubicacion")
                        .WithMany("Vehiculos")
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
