using Microsoft.EntityFrameworkCore;
using API_Adocao.Infrastructure.Persistence;

namespace API_Adocao.Infrastructure.Mappings
{
    public class PetMapping : IEntityTypeConfiguration<Pet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pet> builder)
        {
            builder
                .ToTable("Pets");

            builder
                .HasKey("Id");

            builder
                .Property(p => p.Nome)
                .IsRequired();

            builder
                .Property(p => p.Especie)
                .IsRequired();

            builder
                .Property(p => p.DataResgate)
                .IsRequired();

            builder
                .Property(p => p.Adotado)
                .IsRequired();

        }
    }
}
