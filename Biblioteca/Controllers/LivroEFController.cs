using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models.DTO;
using Biblioteca.Models.Contracts.Services;

namespace Biblioteca.Controllers
{
    public class LivroEFController : Controller
    {
        // Acesso ao serviço

        private readonly ILivroService _livroService;
        private readonly BibliotecaContext _context;

        //Construtor
        // injeção de dependencia, lista os livros assim que o controller é instanciado
        public LivroEFController(ILivroService livroService, BibliotecaContext context)
        {
            _livroService = livroService;
            _context = context;
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
        public async Task<IActionResult> Create([Bind("Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro) // Post
        {
            try
            {
                _livroService.Cadastrar(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Edit(string? id)
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

        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("ID,Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro)
        {
            if (string.IsNullOrEmpty(livro.ID))
            {
                return NotFound();
            }

            try
            {
                _livroService.Atualizar(livro);
                RedirectToAction("List");
            }
            catch (Exception ex)
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
        public async Task<IActionResult> Delete([Bind("ID,Nome,Autor,Editora,DataPublicacao,ISBN")] LivroDTO livro)
        {


            _livroService.Deletar(livro.ID);
            await _context.SaveChangesAsync();

            return RedirectToAction("List");
        }
    }
}
