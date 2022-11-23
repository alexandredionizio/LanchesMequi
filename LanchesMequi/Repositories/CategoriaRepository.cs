using LanchesMequi.Context;
using LanchesMequi.Models;
using LanchesMequi.Repositories.Interfaces;

namespace LanchesMequi.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
