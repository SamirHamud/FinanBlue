﻿using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using FinanBlue.Services.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return null;
        }
        [HttpPost("CreateEmpresa")]
        public EmpresaResponse CreatePost([FromBody] EmpresaRequest request)
        {
            return null;
            //return "";
        }
    }
}
