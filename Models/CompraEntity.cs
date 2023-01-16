using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models
{
    public class CompraEntity
    {
        [Key]
        public int CodCompra { get; set; }

        [ForeignKey("ProdutoEntity")]
        public int CodProduto { get; set; }

        [ForeignKey("EmpresaEntity")]
        public int CodEmpresa { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public virtual ProdutoEntity ProdutoEntity { get; set; }
        public virtual EmpresaEntity EmpresaEntity { get; set; }
      

    }
}
