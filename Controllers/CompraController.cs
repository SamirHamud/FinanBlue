using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using FinanBlue.Services.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Controllers
{
    public class CompraController : Controller
    {
        private readonly ICompraService _compraService;
        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpGet("ListCompra")]
        public List<CompraResponse> ListCompra()
        {
            return null;
        }
        [HttpPost("CreateCompra")]
        public CompraResponse CreateCompra([FromBody] CompraRequest request)
        {
            return null;
            //return "";
        }
    }
}
