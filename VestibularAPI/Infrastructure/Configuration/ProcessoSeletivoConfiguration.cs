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
    public class ProcessoSeletivoConfiguration : IEntityTypeConfiguration<ProcessoSeletivo>
    {
        public void Configure(EntityTypeBuilder<ProcessoSeletivo> builder)
        {
            builder.ToTable("ProcessosSeletivos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");
            
            builder.Property(p => p.DataInicio)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.DataTermino)
                .IsRequired()
                .HasColumnType("datetime");

        }
    }
}
