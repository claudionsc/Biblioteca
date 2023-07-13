using Biblioteca.Models.DTO;

namespace Biblioteca.Models.Contracts.Services
{
    // Interface (Implementação POO, )
    public interface ILivroService
    {
        void Cadastrar(LivroDTO livro); // metodo sem retorno que cadastra um livro


        List<LivroDTO> Listar();
    }
}
