using FinanBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository.InterfaceRepository
{
   public interface ICompraRepository
    {
        Task<List<CompraEntity>> GetCompraAsync();
        Task<CompraEntity> InsertCompraAsync(CompraEntity request);
    }
}
