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
        public async Task<ActionResult> ListCompraAsync()
        {
            return Ok(await _compraService.ListCompraAsync());

        }
        [HttpPost("CreateCompra")]
        public async Task<ActionResult> CreateCompra([FromBody] CompraRequest request)
        {
            try
            {
                return new CreatedResult("", await _compraService.CreateCompraAsync(request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
