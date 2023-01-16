using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models.Request
{
    public class CompraRequest
    {
        public int cod_produto { get; set; }
        public int cod_empresa { get; set; }
        public double quantidade_compra { get; set; }
    }
}
