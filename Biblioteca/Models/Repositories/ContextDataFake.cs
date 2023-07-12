using Biblioteca.Models.DTO;

// Banco de dados fake

namespace Biblioteca.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<LivroDTO> Livros; // Lista de livros
        // static é um objeto que não será instanciado

        // Construtor para instanciar o livro
        /* 
          Método padrão da classe, executado quando o objeto é instanciado 
          Explicação sobre construtores - https://pt.stackoverflow.com/questions/73530/para-que-serve-um-construtor
         */
        static ContextDataFake()
        {
            Livros = new List<LivroDTO>();
            InitializeData();
        }

        // Dados dos livros
        private static void InitializeData()
        {
            var livro01 = new LivroDTO("Teste01", "Claudio", "DotNet", DateTime.Now, "122321");
            Livros.Add(livro01);

            var livro02 = new LivroDTO("Teste02", "Luis", "CSharp", DateTime.Now, "555667");
            Livros.Add(livro02);

            var livro03 = new LivroDTO("Teste03", "Gabriel", "DotNet", DateTime.Now, "010110");
            Livros.Add(livro03);

            var livro04 = new LivroDTO("Teste04", "Claudio", "MVC", DateTime.Now, "223322112");
            Livros.Add(livro04);

            var livro05 = new LivroDTO("Teste05", "Luis", "ASP.NET", DateTime.Now, "995455");
            Livros.Add(livro05);

            var livro06 = new LivroDTO("Teste06", "Gabriel", "Razor", DateTime.Now, "010cs6110");
            Livros.Add(livro06);
        }
    }
}
