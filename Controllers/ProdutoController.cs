using FinanBlue.Models;
using FinanBlue.Services.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet("ListProduto")]
        public List<ProdutoResponse> ListProduto()
        {
            return null;
        }
        [HttpPost("CreateProduto")]
        public ProdutoResponse CreateProduto([FromBody] ProdutoRequest request)
        {
            return null;
            //return "";
        }
    }
}
