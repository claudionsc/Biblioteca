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
            throw new NotImplementedException();
        }
    }
}
