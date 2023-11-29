using EFCore8SQLRaw.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore8SQLRaw.EF.Configuration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Nome).HasMaxLength(20);
            builder.Property(p => p.Preco).HasPrecision(6,2);

            builder.HasOne(p => p.Editora)
                   .WithMany()
                   .HasForeignKey(p => p.Id_Editora);
        }
    }
}
