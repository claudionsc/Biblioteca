using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.DTO;

// Acessar camada de repositório e disponibilizar a quem requisitar o serviço de livros
// O serviço vai ser chamado independente do banco de dados

/*
Os Services são responsáveis pela lógica de negócio da sua aplicação, 
além de ser responsável por se comunicar com as camadas mais internas do Software, 
como por exemplo, uma camada de Dados.
 */

namespace Biblioteca.Models.Services
{
    public class LivroServices : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        // objeto para ler o repositorio

        // Contrutor com injeção de dependência da interface
        /*
            o objeto vai ser recebido no momento da instância 
            desse serviço
         */
        public LivroServices(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
            // Objeto criado será recebido no momento da instância desse serviço
        }

        // implementação dos métodos da entidade

        public void Cadastrar(LivroDTO livro)
        {
            try
            {
                 _livroRepository.Cadastrar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDTO> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch (Exception ex) 
            {
                throw ex;
            }


        }
    }
}
