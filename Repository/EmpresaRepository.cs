using FinanBlue.Models;
using FinanBlue.Repository.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly AppDbContext db;
        public EmpresaRepository(AppDbContext context)
        {
            db = context;
        }

        public List<EmpresaEntity> GetEmpresa()
        {
            return db.EmpresaEntity.ToList();
        }

        public EmpresaEntity GetEmpresaById(int codEmpresa)
        {
            return db.EmpresaEntity.FirstOrDefault(x => x.CodEmpresa == codEmpresa);
        }
        public EmpresaEntity InsertEmpresa(EmpresaEntity request)
        {
            var retorno = db.EmpresaEntity.Add(request);
            db.SaveChanges();
            return retorno.Entity;
        }
    }
}
