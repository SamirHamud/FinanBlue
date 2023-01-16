using AutoMapper;
using FinanBlue.Models;
using FinanBlue.Models.Request;
using FinanBlue.Repository.InterfaceRepository;
using FinanBlue.Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;


        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public List<ProdutoResponse> ListProduto()
        {
            var listProduto = _produtoRepository.GetProduto();
            return _mapper.Map<List<ProdutoResponse>>(listProduto);
        }

        public ProdutoResponse CreateProduto(ProdutoRequest request)
        {
            try
            {
                ProdutoEntity produto = _mapper.Map<ProdutoEntity>(request);
                produto = _produtoRepository.InsertProduto(produto);
                return _mapper.Map<ProdutoResponse>(produto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
