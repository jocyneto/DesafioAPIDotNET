using AutoMapper;
using ProdutoAPI.Data.Dtos;
using ProdutoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Profiles
{
    public class ProdutoProfile : Profile
    {

        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }


    }
}
