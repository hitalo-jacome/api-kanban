﻿// <auto-generated />
using System;
using LinhaDireta.Dados.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241105172320_AlterLinhaDiretaAddTipoUsuario")]
    partial class AlterLinhaDiretaAddTipoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.LinhaDireta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grupo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroDocumento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("Prazo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Protocolo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<int?>("ResponsavelUltimaAtualizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("TipoUsuario")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("LinhaDiretaMessages");
                });

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.LinhaDiretaHistorico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("LinhaDiretaId")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelAlteracaoId")
                        .HasColumnType("int");

                    b.Property<int>("StatusAnterior")
                        .HasColumnType("int");

                    b.Property<int>("StatusAtual")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("TempoNoStatus")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("LinhaDiretaId");

                    b.ToTable("LinhaDiretaHistorico");
                });

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.StatusLinhaDireta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusLinhaDireta");
                });

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.LinhaDireta", b =>
                {
                    b.HasOne("LinhaDireta.Dominio.Entities.StatusLinhaDireta", "StatusLinhaDireta")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusLinhaDireta");
                });

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.LinhaDiretaHistorico", b =>
                {
                    b.HasOne("LinhaDireta.Dominio.Entities.LinhaDireta", "LinhaDireta")
                        .WithMany("Historico")
                        .HasForeignKey("LinhaDiretaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LinhaDireta");
                });

            modelBuilder.Entity("LinhaDireta.Dominio.Entities.LinhaDireta", b =>
                {
                    b.Navigation("Historico");
                });
#pragma warning restore 612, 618
        }
    }
}
