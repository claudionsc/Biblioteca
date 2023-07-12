using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<LivroDTO> Livros;

        static ContextDataFake()
        {
            Livros = new List<LivroDTO>();
            InitializeData();
        }

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
