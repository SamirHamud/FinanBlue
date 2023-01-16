using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Models
{
    
    public class EmpresaEntity
    {
        [Key]
        public int CodEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string CnpjEmpresa { get; set; }
     
    }
}
