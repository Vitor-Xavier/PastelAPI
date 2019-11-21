using Microsoft.EntityFrameworkCore;
using PastelAPI.Models;

namespace PastelAPI.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setor>().HasData(
                new Setor
                {
                    SetorId = 1,
                    Nome = "Pesquisa e Desenvolvimento",
                    Sigla = "P&D"
                });

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    CategoriaId = 1,
                    Nome = "Salgado",
                    Tipo = "Salgado",
                });

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    CategoriaId = 2,
                    Nome = "Pastel",
                    Tipo = "Salgado",
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 1,
                    CategoriaId = 1,
                    Nome = "Coxinha",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 2,
                    CategoriaId = 1,
                    Nome = "Salsicha",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 3,
                    CategoriaId = 1,
                    Nome = "Bolinha de frango com catupiry",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 4,
                    CategoriaId = 1,
                    Nome = "Enroladinho de presento e queijo",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 5,
                    CategoriaId = 1,
                    Nome = "Espeto de frango",
                    ValorUnitario = 5.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 6,
                    CategoriaId = 1,
                    Nome = "Bolinho de mandioca com carne",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 7,
                    CategoriaId = 1,
                    Nome = "Kibe com carne",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 8,
                    CategoriaId = 1,
                    Nome = "Ovo empanado",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 9,
                    CategoriaId = 1,
                    Nome = "Kibe com ovo",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 10,
                    CategoriaId = 2,
                    Nome = "Carne",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 11,
                    CategoriaId = 2,
                    Nome = "Queijo",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 12,
                    CategoriaId = 2,
                    Nome = "Pizza",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 13,
                    CategoriaId = 2,
                    Nome = "Palmito",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 14,
                    CategoriaId = 2,
                    Nome = "Frango com catupiry",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 15,
                    CategoriaId = 2,
                    Nome = "Napolitano",
                    ValorUnitario = 4.5m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 16,
                    CategoriaId = 2,
                    Nome = "Camarão com catupity",
                    ValorUnitario = 5.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 17,
                    CategoriaId = 2,
                    Nome = "Carne com queijo",
                    ValorUnitario = 5.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 18,
                    CategoriaId = 2,
                    Nome = "Bacalhau",
                    ValorUnitario = 5.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 19,
                    CategoriaId = 2,
                    Nome = "Bacon com queijo",
                    ValorUnitario = 5.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 20,
                    CategoriaId = 2,
                    Nome = "Portuguesa",
                    ValorUnitario = 6.0m
                });

            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    ProdutoId = 21,
                    CategoriaId = 2,
                    Nome = "Especial de carne",
                    ValorUnitario = 12.0m
                });
        }
    }
}
