using ExemploEF1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF1.EF
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options): base(options) {}

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(p => p.ID);
            modelBuilder.Entity<Cliente>()
                .Property(p => p.ID)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
