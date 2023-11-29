using EFCore8SQLRaw.EF;
using EFCore8SQLRaw.Models;
using Microsoft.EntityFrameworkCore;

var dbOptions = new DbContextOptionsBuilder<Contexto>()
            .UseSqlServer("data source=(local); initial catalog=AceleraDev; integrated security=true;trusted_connection=true;encrypt=false;multipleactiveresultsets=true;")
            .UseLazyLoadingProxies();

var db = new Contexto(dbOptions.Options);

// Consulta usando Contexto e Classe mapeada
var livros = db.Livro;
foreach(var l in  livros)
{
    Console.WriteLine(l.Nome);
}

// Consulta usando SQL Raw
var livroEditora = db.Database.SqlQuery<LivroEditoraDto>($"select l.Nome Livro,l.preco Preco,e.nome Editora from livro l, editora e where l.Id_Editora = e.id");
foreach (var l in livroEditora)
{
    Console.WriteLine($"{l.Livro} - Ed {l.Editora} - {l.Preco}");
}
