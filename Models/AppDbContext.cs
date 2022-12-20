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
        public virtual DbSet<ProdutoRequest> ProdutoEntity { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
