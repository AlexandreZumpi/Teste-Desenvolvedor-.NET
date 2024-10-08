﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Inscricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroInscricao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("OfertaId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoSeletivoId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("LeadId");

                    b.HasIndex("OfertaId");

                    b.HasIndex("ProcessoSeletivoId");

                    b.ToTable("Inscricoes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Leads", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("VagasDisponiveis")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ofertas", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProcessoSeletivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProcessosSeletivos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Inscricao", b =>
                {
                    b.HasOne("Domain.Entities.Lead", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Oferta", "Oferta")
                        .WithMany()
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ProcessoSeletivo", "ProcessoSeletivo")
                        .WithMany()
                        .HasForeignKey("ProcessoSeletivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lead");

                    b.Navigation("Oferta");

                    b.Navigation("ProcessoSeletivo");
                });
#pragma warning restore 612, 618
        }
    }
}
