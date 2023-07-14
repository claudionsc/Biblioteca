using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models.DTO;

namespace Biblioteca.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext (DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Biblioteca.Models.DTO.LivroDTO> Livros { get; set; } = default!;
    }
}
