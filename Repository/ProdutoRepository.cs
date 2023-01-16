using FinanBlue.Models;
using FinanBlue.Repository.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext db;
        public ProdutoRepository(AppDbContext context)
        {
            db = context;
        }

        public List<ProdutoEntity> GetProduto()
        {
            return db.ProdutoEntity.ToList();
        }

        public ProdutoEntity InsertProduto(ProdutoEntity request)
        {
            var retorno = db.ProdutoEntity.Add(request);
            db.SaveChanges();
            return retorno.Entity;
        }

        public ProdutoEntity GetProdutoById(int CodProduto)
        {
            return db.ProdutoEntity.FirstOrDefault(x => x.CodProduto == CodProduto);
        }

        public ProdutoEntity AtualizaProduto(ProdutoEntity request)
        {
            var retorno = db.ProdutoEntity.Update(request);
            db.SaveChanges();
            return retorno.Entity;
        }
    }
}
