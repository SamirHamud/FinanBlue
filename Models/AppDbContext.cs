using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<EmpresaEntity> EmpresaEntity { get; set; }
        public virtual DbSet<ProdutoEntity> ProdutoEntity { get; set; }
        public virtual DbSet<CompraEntity> CompraEntity { get; set; }



        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
