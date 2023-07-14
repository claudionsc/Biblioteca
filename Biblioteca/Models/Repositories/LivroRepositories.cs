using Biblioteca.Data;
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
    public class LivroRepositories: ILivroRepository
    {

        private readonly BibliotecaContext _context;

        public LivroRepositories(BibliotecaContext context)
        {
            _context = context;
        }

        public void Atualizar(LivroDTO livro)
        {
            var pesquisa = PesquisarPorID(livro.ID);
            _context.Livros.Remove(pesquisa);

            pesquisa.Nome = livro.Nome;
            pesquisa.Autor = livro.Autor;
            pesquisa.Editora = livro.Editora;
            pesquisa.DataPublicacao = livro.DataPublicacao;
            pesquisa.ISBN = livro.ISBN;

            Cadastrar(pesquisa);
        }

        // implementação dos métodos da entidade
        public void Cadastrar(LivroDTO livro) 
        {
            _context.Livros.Add(livro);
        }

       

        public List<LivroDTO> Listar()
        {
            var livros = _context.Livros;
            return livros
                .OrderBy(n => n.Nome)
                .ToList();
        }

        public LivroDTO PesquisarPorID(string id)
        {
            var livro = _context.Livros.FirstOrDefault(n => n.ID == id);
            return livro;
        }


        public void Deletar(string id)
        {
            var pesquisa = PesquisarPorID(id);
            _context.Livros.Remove(pesquisa);
        }
    }
}
