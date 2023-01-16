using AutoMapper;
using FinanBlue.Models;
using FinanBlue.Models.Request;
using FinanBlue.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanBlue.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Mapping empresa
            CreateMap<EmpresaRequest, EmpresaEntity>()
                .ForMember(x => x.NomeEmpresa, opt => opt.MapFrom(src => src.nome_empresa))
                .ForMember(x => x.CnpjEmpresa, opt => opt.MapFrom(src => src.cnpj_empresa));
            CreateMap<EmpresaEntity, EmpresaResponse>()
                .ForMember(x => x.cod_empresa, opt => opt.MapFrom(src => src.CodEmpresa))
                .ForMember(x => x.cnpj_empresa, opt => opt.MapFrom(src => src.CnpjEmpresa))
                .ForMember(x => x.nome_empresa, opt => opt.MapFrom(src => src.NomeEmpresa));

            //Mapping Produto
            CreateMap<ProdutoRequest, ProdutoEntity>()
               .ForMember(x => x.NomeProduto, opt => opt.MapFrom(src => src.nome_produto))
               .ForMember(x => x.ValorProduto, opt => opt.MapFrom(src => src.valor_produto))
               .ForMember(x => x.Quantidade, opt => opt.MapFrom(src => src.quantidade));
            CreateMap<ProdutoEntity, ProdutoResponse>()
                .ForMember(x => x.cod_produto, opt => opt.MapFrom(src => src.CodProduto))
                .ForMember(x => x.nome_produto, opt => opt.MapFrom(src => src.NomeProduto))
                .ForMember(x => x.valor_produto, opt => opt.MapFrom(src => src.ValorProduto))
                .ForMember(x => x.quantidade, opt => opt.MapFrom(src => src.Quantidade));

            //Mapping Compra
            CreateMap<CompraModel, CompraEntity>()
               .ForMember(x => x.CodProduto, opt => opt.MapFrom(src => src.cod_produto))
               .ForMember(x => x.CodEmpresa, opt => opt.MapFrom(src => src.cod_empresa))
               .ForMember(x => x.Quantidade, opt => opt.MapFrom(src => src.quantidade_compra))
               .ForMember(x => x.ValorCompra, opt => opt.MapFrom(src => src.valor_compra))
               .ForMember(x => x.DataCompra, opt => opt.MapFrom(src => DateTime.Now));

            CreateMap<CompraRequest, CompraModel>()
             .ForMember(x => x.cod_produto, opt => opt.MapFrom(src => src.cod_produto))
             .ForMember(x => x.cod_empresa, opt => opt.MapFrom(src => src.cod_empresa));
             
            CreateMap<CompraEntity, CompraResponse>()
                .ForMember(x=>x.cod_compra, opt => opt.MapFrom(src =>src.CodCompra))
                .ForMember(x => x.nome_empresa, opt => opt.MapFrom(src => src.EmpresaEntity.NomeEmpresa))
                .ForMember(x => x.nome_produto, opt => opt.MapFrom(src => src.ProdutoEntity.NomeProduto))
                .ForMember(x => x.quantidade_compra, opt => opt.MapFrom(src => src.Quantidade))
                .ForMember(x => x.valor_compra, opt => opt.MapFrom(src => src.ValorCompra))
                .ForMember(x => x.data_compra, opt => opt.MapFrom(src => src.DataCompra));
        }
    }
}
