using EFCore8SQLRaw.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore8SQLRaw.EF
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Editora> Editora { get; set; }
        public DbSet<Livro> Livro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
