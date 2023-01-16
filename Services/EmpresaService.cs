using AutoMapper;
using FinanBlue.Models;
using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using FinanBlue.Repository.InterfaceRepository;
using FinanBlue.Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IMapper _mapper;

        public EmpresaService(IEmpresaRepository empresaRepository, IMapper mapper)
        {
            _empresaRepository = empresaRepository;
            _mapper = mapper;
        }

        public List<EmpresaResponse> ListEmpresa()
        {
            var listEmpresa = _empresaRepository.GetEmpresa();
            return _mapper.Map<List<EmpresaResponse>>(listEmpresa);
        }

        public EmpresaResponse CreateEmpresa(EmpresaRequest request)
        {
            EmpresaEntity empresa = _mapper.Map<EmpresaEntity>(request);
            empresa = _empresaRepository.InsertEmpresa(empresa);
            return _mapper.Map<EmpresaResponse>(empresa);   
        }
    }
}
