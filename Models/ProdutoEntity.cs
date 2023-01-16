using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models
{
    public class ProdutoEntity
    {
        [Key]
        public int CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorProduto { get; set; }
      
    }
}
