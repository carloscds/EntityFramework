using ExemploEF1.Domain;
using ExemploEF1.EF;
using Microsoft.EntityFrameworkCore;

namespace ExemploEF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opt = new DbContextOptionsBuilder<DbContext>()
                .UseSqlServer("data source=(local); initial catalog=ExemploEF;integrated security=true;trusted_connection=true; encrypt=false;")
                .LogTo(l => Console.WriteLine(l));
            var db = new Contexto(opt.Options);

            var cli = new Cliente { Nome = "Carlos" };
            db.Cliente.Add(cli);
            db.SaveChanges();

            var dados = db.Cliente.Where(w => w.ID > 0);
            foreach(var c in dados)
            {
                Console.WriteLine(c.Nome);
            }
        }
    }
}