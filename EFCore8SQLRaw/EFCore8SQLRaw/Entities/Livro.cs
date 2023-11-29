namespace EFCore8SQLRaw.Entities
{
    public class Livro
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime Lancamento { get; set; }
        public int Id_Editora {get; set;}
        public virtual Editora Editora { get; set; }
    }
}
