using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PastelAPI.Models;
using PastelAPI.Services.Categorias;

namespace PastelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        /// <summary>
        /// Busca Categoria pelo seu Id.
        /// </summary>
        /// <param name="categoriaId">Id da Categoria</param>
        /// <returns>Categoria</returns>
        [HttpGet("{categoriaId:int}")]
        public ValueTask<Categoria> GetCategoriaById(int categoriaId) =>
            _categoriaService.GetCategoriaById(categoriaId);

        /// <summary>
        /// Lista Categorias.
        /// </summary>
        /// <returns>Lista de Categorias</returns>
        [HttpGet]
        public IAsyncEnumerable<Categoria> GetCategorias() =>
            _categoriaService.GetCategorias();

        /// <summary>
        /// Adiciona Categoria.
        /// </summary>
        /// <param name="categoria">Categoria</param>
        /// <returns></returns>
        [HttpPost]
        public Task<bool> PostCategoria(Categoria categoria) =>
            _categoriaService.CreateCategoria(categoria);

        /// <summary>
        /// Altera Categoria existente.
        /// </summary>
        /// <param name="categoriaId">Id da Categoria</param>
        /// <param name="categoria">Categoria</param>
        /// <returns></returns>
        [HttpPut("{categoriaId:int}")]
        public Task<bool> PutCategoria(int categoriaId, Categoria categoria) =>
            _categoriaService.UpdateCategoria(categoriaId, categoria);

        /// <summary>
        /// Remove Categoria.
        /// </summary>
        /// <param name="categoriaId">Id da Categoria</param>
        /// <returns></returns>
        [HttpDelete("{categoriaId:int}")]
        public Task<bool> DeleteCategoria(int categoriaId) =>
            _categoriaService.DeleteCategoria(categoriaId);
    }
}