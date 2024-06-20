﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NominaEmpleados.DAL;

#nullable disable

namespace NominaEmpleados.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240619134808_PuestosTrabajo")]
    partial class PuestosTrabajo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("NominaEmpleados.Models.Departamentos", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            DepartamentoId = 1,
                            Departamento = "Recursos Humanos"
                        },
                        new
                        {
                            DepartamentoId = 2,
                            Departamento = "Finanzas y Contabilidad"
                        },
                        new
                        {
                            DepartamentoId = 3,
                            Departamento = "Ventas"
                        },
                        new
                        {
                            DepartamentoId = 4,
                            Departamento = "Tecnología de la Información"
                        },
                        new
                        {
                            DepartamentoId = 5,
                            Departamento = "Investigación y Desarrollo"
                        },
                        new
                        {
                            DepartamentoId = 6,
                            Departamento = "Servicio al Cliente"
                        },
                        new
                        {
                            DepartamentoId = 7,
                            Departamento = "Compras"
                        });
                });

            modelBuilder.Entity("NominaEmpleados.Models.PuestosTrabajo", b =>
                {
                    b.Property<int>("PuestoTrabajoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Sueldo")
                        .HasColumnType("TEXT");

                    b.HasKey("PuestoTrabajoId");

                    b.ToTable("PuestosTrabajos");
                });
#pragma warning restore 612, 618
        }
    }
}