using Biblioteca.Models.DTO;

/*
funcionam como se fosse um contrato, ou seja, elas determinam quais são os métodos 
que a classe deve implementar.
 */

namespace Biblioteca.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(LivroDTO livro); // metodo sem retorno que cadastra um livro

        List<LivroDTO> Listar();

        LivroDTO PesquisarPorID(string id);

        void Atualizar(LivroDTO livro);


    }
}
