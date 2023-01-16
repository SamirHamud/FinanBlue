using FinanBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Services.InterfaceService
{
    public interface IProdutoService
    {
        List<ProdutoResponse> ListProduto();
        ProdutoResponse CreateProduto(ProdutoRequest request);
    }
}
