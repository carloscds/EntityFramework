using EngenhariaReversa.Models;
using Microsoft.EntityFrameworkCore;

namespace EngenhariaReversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opt = new DbContextOptionsBuilder<EF1Context>()
                .UseSqlServer("data source=(local); initial catalog=EF1;integrated security=true;trusted_connection=true; encrypt=false;");
            var db = new EF1Context(opt.Options);

            foreach(var c in db.Cliente) 
            {
                Console.WriteLine($"{c.Nome}");
            }
        }
    }
}