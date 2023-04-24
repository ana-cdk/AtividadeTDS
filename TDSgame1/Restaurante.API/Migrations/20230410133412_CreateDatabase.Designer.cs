﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurante.API.Data;

#nullable disable

namespace Restaurante.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230410133412_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Restaurante.API.Models.Mesa", b =>
                {
                    b.Property<int>("MesaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("HoraAbertura")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ocupada")
                        .HasColumnType("INTEGER");

                    b.HasKey("MesaId");

                    b.ToTable("Mesas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
