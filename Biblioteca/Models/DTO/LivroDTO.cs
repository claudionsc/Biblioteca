namespace Biblioteca.Models.DTO
{
    public class LivroDTO
    {
        // Propriedades
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public DateTime DataPublicacao { get; set; }
        public long ISBN { get; set; }

        // Construtores
        public LivroDTO(
            string id, string nome, string autor, string editora, 
            DateTime dataPublicacao, long isbn
            ) : this(nome, autor, editora, dataPublicacao, isbn)
        {
            this.ID = id;
        }
        
        public LivroDTO(string nome, string autor, string editora, DateTime dataPublicacao, long isbn)
        {
            this.Nome = nome;
            this.Editora = editora;
            this.Autor = autor;
            this.DataPublicacao = dataPublicacao;
            this.ISBN = isbn;
        }
    }
}
