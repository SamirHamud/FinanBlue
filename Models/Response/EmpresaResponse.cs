using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models.Response
{
    public class EmpresaResponse
    {
        public int cod_empresa { get; set; }
        public string nome_empresa { get; set; }
        public string cnpj_empresa { get; set; }
    }
}
