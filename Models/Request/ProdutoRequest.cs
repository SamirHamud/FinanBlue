using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models
{
    public class ProdutoRequest
    {
        public string nome_produto { get; set; }
        public double quantidade { get; set; }
        public decimal valor_produto { get; set; }
    }
}
