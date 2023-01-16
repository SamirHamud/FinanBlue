using FinanBlue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository.InterfaceRepository
{
   public interface IEmpresaRepository
    {
        List<EmpresaEntity> GetEmpresa();
        EmpresaEntity InsertEmpresa(EmpresaEntity request);
        EmpresaEntity GetEmpresaById(int codEmpresa);
    }
}
