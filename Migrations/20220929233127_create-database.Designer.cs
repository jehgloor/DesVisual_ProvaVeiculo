﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prova.Data;

namespace prova.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220929233127_create-database")]
    partial class createdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("prova.Model.Veiculo", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .HasColumnType("text");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
