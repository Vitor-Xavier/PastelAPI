using PastelAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPI.Services.Categorias
{
    public interface ICategoriaService
    {
        ValueTask<Categoria> GetCategoriaById(int categoriaId);

        IAsyncEnumerable<Categoria> GetCategorias();

        Task<bool> CreateCategoria(Categoria categoria);

        Task<bool> UpdateCategoria(int categoriaId, Categoria categoria);

        Task<bool> DeleteCategoria(int categoriaId);
    }
}
