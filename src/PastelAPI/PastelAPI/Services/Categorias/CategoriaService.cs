using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PastelAPI.Context;
using PastelAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPI.Services.Categorias
{
    public class CategoriaService : ICategoriaService
    {
        private readonly PastelContext _context;

        private readonly ILogger<CategoriaService> _logger;

        public CategoriaService(ILogger<CategoriaService> logger, PastelContext context)
        {
            _context = context;
            _logger = logger;
        }

        public ValueTask<Categoria> GetCategoriaById(int categoriaId) =>
            _context.Categorias.FindAsync(categoriaId);

        public IAsyncEnumerable<Categoria> GetCategorias() =>
            _context.Categorias;

        public async Task<bool> CreateCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> UpdateCategoria(int categoriaId, Categoria categoria)
        {
            _context.Categorias.Attach(categoria);
            _context.Entry(categoria).State = EntityState.Modified;

            _logger.LogInformation($"Categoria {categoriaId} alterada.");
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteCategoria(int categoriaId)
        {
            var categoria = new Categoria { CategoriaId = categoriaId };
            _context.Categorias.Attach(categoria);
            _context.Entry(categoria).State = EntityState.Deleted;

            _logger.LogInformation($"Categoria {categoriaId} deletada.");
            return await _context.SaveChangesAsync() == 1;
        }
    }
}
