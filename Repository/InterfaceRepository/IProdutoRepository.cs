using FinanBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository.InterfaceRepository
{
   public interface IProdutoRepository
   {
        List<ProdutoEntity> GetProduto();
        ProdutoEntity InsertProduto(ProdutoEntity request);
        ProdutoEntity GetProdutoById(int CodProduto);
        ProdutoEntity AtualizaProduto(ProdutoEntity request);
   }
}
