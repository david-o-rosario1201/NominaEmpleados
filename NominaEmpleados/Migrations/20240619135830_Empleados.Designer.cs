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
    [Migration("20240619135830_Empleados")]
    partial class Empleados
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

            modelBuilder.Entity("NominaEmpleados.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Profesion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PuestoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("PuestoId");

                    b.ToTable("Empleados");
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

            modelBuilder.Entity("NominaEmpleados.Models.Empleados", b =>
                {
                    b.HasOne("NominaEmpleados.Models.Departamentos", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NominaEmpleados.Models.PuestosTrabajo", "PuestosTrabajo")
                        .WithMany()
                        .HasForeignKey("PuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("PuestosTrabajo");
                });
#pragma warning restore 612, 618
        }
    }
}
