using AutoMapper;
using FinanBlue.Models;
using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using FinanBlue.Repository.InterfaceRepository;
using FinanBlue.Services.InterfaceService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanBlue.Services
{
    public class CompraService : ICompraService
    {

        private readonly ICompraRepository _compraRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IMapper _mapper;


        public CompraService(ICompraRepository compraRepository, IMapper mapper, IProdutoRepository produtoRepository, IEmpresaRepository empresaRepository)
        {
            _compraRepository = compraRepository;
            _produtoRepository = produtoRepository;
            _empresaRepository = empresaRepository;
            _mapper = mapper;
        }
        public async Task<List<CompraResponse>> ListCompraAsync()
        {
            var teste = await _compraRepository.GetCompraAsync();
            return _mapper.Map<List<CompraResponse>>(teste);
        }

        public async Task<CompraResponse> CreateCompraAsync(CompraRequest request)
        {
            var produto = _produtoRepository.GetProdutoById(request.cod_produto);
            var empresa = _empresaRepository.GetEmpresaById(request.cod_empresa);
            if (empresa == null)
            {
                throw new Exception("Empresa não existe");
            }
            if (!ValidaLastro(produto.Quantidade, request.quantidade_compra))
            {
                throw new Exception("Não foi possível completar sua compra, não temos lastro disponivel para esse produto");
            }

            CompraModel compraModel = _mapper.Map<CompraModel>(request);
            compraModel.valor_compra = CalculaValorTotalCompra(request.quantidade_compra, produto.ValorProduto);

            if (!AtualizaLastro(produto, request.quantidade_compra))
            {
                throw new Exception("Não foi possível atualizar o lastro do produto, tente novamente mais tarde.");
            }

            CompraEntity compra = _mapper.Map<CompraEntity>(compraModel);
            compra = await _compraRepository.InsertCompraAsync(compra);
            return _mapper.Map<CompraResponse>(compra);
        }

        public bool ValidaLastro(double quantidadeProduto, double quantidadeSolicitada) => quantidadeProduto >= quantidadeSolicitada;

        public bool AtualizaLastro(ProdutoEntity produto, double quantidade)
        {
            try
            {
                produto.Quantidade = produto.Quantidade - quantidade;
                _produtoRepository.AtualizaProduto(produto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public decimal CalculaValorTotalCompra(double quantidade, decimal valorProduto)
        {
            return (decimal)quantidade * valorProduto;
        }

    }
}
