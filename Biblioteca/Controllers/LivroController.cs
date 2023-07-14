using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.DTO;
using Microsoft.AspNetCore.Mvc;

// O controller acessa o serviço

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        // Acesso ao serviço

        private readonly ILivroService _livroService;

        //Construtor
        // injeção de dependencia, lista os livros assim que o controller é instanciado
        public LivroController(ILivroService livroService)  
        {
            _livroService = livroService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
               var livros = _livroService.Listar();
                return View(livros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Create() // Get
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // validar controlador, previne ataque csrf
        // Bind serve para agrupar quais os campos serão entendidos (nesse caso salvos) pela action
        public IActionResult Create([Bind("Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro) // Post
        {
            try
            {
                _livroService.Cadastrar(livro);
                return RedirectToAction("List");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Edit(string? id) 
        {
            if(string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var livro = _livroService.PesquisarPorID(id);
            if(livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("ID,Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro) 
        {
            if(string.IsNullOrEmpty(livro.ID))
            {
                return NotFound();
            }

            try
            {
                _livroService.Atualizar(livro);
                RedirectToAction("List");
            }
            catch(Exception ex) 
            {
                throw ex;
            }

            return View();
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var livro = _livroService.PesquisarPorID(id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        public IActionResult Delete(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var livro = _livroService.PesquisarPorID(id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }
        
        [HttpPost]
        public IActionResult Delete([Bind("ID,Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro)
        {
          

            _livroService.Deletar(livro.ID);
            return RedirectToAction("List");
        }

    }
}
