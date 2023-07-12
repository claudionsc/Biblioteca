using Biblioteca.Models.Contracts.Services;
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
    }
}
