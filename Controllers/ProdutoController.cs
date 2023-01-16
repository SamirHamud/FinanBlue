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
            return _produtoService.ListProduto();
        }
        [HttpPost("CreateProduto")]
        public ActionResult CreateProduto([FromBody] ProdutoRequest request)
        {
            try
            {
                return new CreatedResult("", _produtoService.CreateProduto(request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
