using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Contracts.Services
{
    public interface ILivroService
    {
        List<LivroDTO> Listar();
    }
}
