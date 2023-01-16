using FinanBlue.Models;
using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Services.InterfaceService
{
    public interface ICompraService
    {
        Task<List<CompraResponse>> ListCompraAsync();
        Task<CompraResponse> CreateCompraAsync(CompraRequest request);
    }
}
