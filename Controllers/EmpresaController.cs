using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using FinanBlue.Services.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FinanBlue.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        [HttpGet("ListEmpresa")]
        public List<EmpresaResponse> ListEmpresa()
        {
            return _empresaService.ListEmpresa();
        }
        [HttpPost("CreateEmpresa")]
        public ActionResult CreateEmpresa([FromBody] EmpresaRequest request)
        {
            try
            {
                return new CreatedResult("", _empresaService.CreateEmpresa(request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
