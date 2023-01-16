using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models.Response
{
    public class CompraResponse
    {
        public int cod_compra { get; set; }
        public string nome_produto { get; set; }
        public string  nome_empresa { get; set; }
        public double quantidade_compra { get; set; }
        public decimal valor_compra { get; set; }
        public DateTime data_compra { get; set; }
    }
}
