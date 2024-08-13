using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class OfertaConfiguration : IEntityTypeConfiguration<Oferta>
    {
        public void Configure(EntityTypeBuilder<Oferta> builder)
        {
            builder.ToTable("Ofertas");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(o => o.Descricao)
                .HasColumnType("varchar(500)");
            
            builder.Property(o => o.VagasDisponiveis)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
