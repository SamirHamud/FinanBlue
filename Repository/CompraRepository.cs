using FinanBlue.Models;
using FinanBlue.Repository.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository
{
    public class CompraRepository : ICompraRepository
    {
        private readonly AppDbContext db;
        public CompraRepository(AppDbContext context)
        {
            db = context;
        }

        public async Task<List<CompraEntity>> GetCompraAsync()
        {
            return await db.CompraEntity
               .Include(x => x.EmpresaEntity)
               .Include(x => x.ProdutoEntity).ToListAsync();
        }

        public async Task<CompraEntity> InsertCompraAsync(CompraEntity request)
        {
            var retorno = await db.CompraEntity.AddAsync(request);
            db.SaveChanges();
            return retorno.Entity;
        }
    }
}
