using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Contracts.Services
{
    // Interface (Implementação POO, )
    public interface ILivroService
    {
        List<LivroDTO> Listar();
    }
}
