using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        List<LivroDTO> Listar();

    }
}
