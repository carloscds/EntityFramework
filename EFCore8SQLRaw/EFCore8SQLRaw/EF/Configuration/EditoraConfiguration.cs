using EFCore8SQLRaw.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore8SQLRaw.EF.Configuration
{
    public class EditoraConfiguration : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Nome).HasMaxLength(20);
            builder.Property(p => p.Endereco).HasMaxLength(20);
        }
    }
}
