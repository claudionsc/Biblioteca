using Biblioteca.Models.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models.DTO
{
    public class LivroDTO : EntidadeBase // herança da entidade base, Guid
    {
        // Propriedades
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de publicação")]
        public DateTime DataPublicacao { get; set; }
        public string ISBN { get; set; }

        // Construtores
        public LivroDTO() // necessário para trabalhar com formulários
        {
            
        }

        public LivroDTO(
            string id, string nome, string autor, string editora, 
            DateTime dataPublicacao, string isbn
            ) : this(nome, autor, editora, dataPublicacao, isbn)
        {
            this.ID = id;
        }
        
        public LivroDTO(string nome, string autor, string editora, DateTime dataPublicacao, string isbn)
        {
            this.Nome = nome;
            this.Editora = editora;
            this.Autor = autor;
            this.DataPublicacao = dataPublicacao;
            this.ISBN = isbn;
        }
    }
}
