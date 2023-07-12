using Biblioteca.Models.DTO;

/*
funcionam como se fosse um contrato, ou seja, elas determinam quais são os métodos 
que a classe deve implementar.
 */

namespace Biblioteca.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        List<LivroDTO> Listar();
    }
}
