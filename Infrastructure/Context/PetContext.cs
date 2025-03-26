using Microsoft.EntityFrameworkCore;
using API_Adocao.Infrastructure.Mappings;
using API_Adocao.Infrastructure.Persistence;

namespace API_Adocao.Infrastructure.Context
{
    public class PetContext(DbContextOptions<PetContext> options) : DbContext(options)
    {
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PetMapping());
        }
    }
}
