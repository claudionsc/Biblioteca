using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Repositories
{
    public class LivroRrepositories: ILivroRepository
    {
        public List<LivroDTO> Listar()
        {
            var livros = ContextDataFake.Livros;
            return livros
                .OrderBy(n => n.Nome)
                .ToList();
        }
    }
}
