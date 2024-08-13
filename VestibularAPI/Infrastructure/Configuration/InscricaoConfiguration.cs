using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class InscricaoConfiguration : IEntityTypeConfiguration<Inscricao>
    {
        public void Configure(EntityTypeBuilder<Inscricao> builder)
        {
            builder.ToTable("Inscricoes");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.NumeroInscricao)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar(10)");

            builder.Property(i => i.Data)
                .IsRequired()
                .HasColumnType("datetime"); ;

            builder.Property(i => i.Status)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            // Configuração de relacionamentos
            builder.HasOne(i => i.Lead)
                .WithMany()
                .HasForeignKey(i => i.LeadId);

            builder.HasOne(i => i.ProcessoSeletivo)
                .WithMany()
                .HasForeignKey(i => i.ProcessoSeletivoId);

            builder.HasOne(i => i.Oferta)
                .WithMany()
                .HasForeignKey(i => i.OfertaId);


            /*
             *             modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Lead)
                .WithMany()
                .HasForeignKey(i => i.LeadId);

            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.ProcessoSeletivo)
                .WithMany()
                .HasForeignKey(i => i.ProcessoSeletivoId);

            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Oferta)
                .WithMany()
                .HasForeignKey(i => i.OfertaId);
             */

        }
    }
}
