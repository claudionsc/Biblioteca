using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.DTO;

// Acesso às informações do bando de dados
/* 
 Separar camada de acesso de dados da camada de domínio
onde estão as regras de negócio

Abstrai toda a parte de armazenamento de dados e consultas ao banco
É o mediador entre a aplicação e o mapeamento de objetos

Consultas são realizadas aqui

Sobre repository - https://www.linkedin.com/pulse/voc%C3%AA-j%C3%A1-ouviu-falar-sobre-o-repository-pattern-samuel-ramos/?originalSubdomain=pt
 */

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
