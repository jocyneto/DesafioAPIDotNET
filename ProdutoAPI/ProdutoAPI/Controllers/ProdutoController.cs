using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Data;
using ProdutoAPI.Data.Dtos;
using ProdutoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoContext _context;
        private IMapper _mapper;

        public ProdutoController(ProdutoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateProdutoDto produtoDto)
        {
            /*
            Produto produto = new Produto
            {
                Descricao = produtoDto.Descricao,
                Flag = produtoDto.Flag,
                DataFab = produtoDto.DataFab,
                DataVal = produtoDto.DataVal,
                CodigoFornecedor = produtoDto.CodigoFornecedor,
                DescricaoFornecedor = produtoDto.DescricaoFornecedor,
                CNPJFornecedor = produtoDto.CNPJFornecedor
            };
            */

            Produto produto = _mapper.Map<Produto>(produtoDto);


            int validador = DateTime.Compare(produto.DataFab, produto.DataVal);
            if(validador <= 0)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return CreatedAtAction(nameof(recuperaProdutoId), new { id = produto.IdProduto }, produto);
            }
            return NotFound();
        }

        [HttpGet]
        public IEnumerable<Produto> RecuperaProduto()
        {
            return _context.Produtos;
        }

        [HttpGet("{id}")]
        public IActionResult recuperaProdutoId(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.IdProduto == id);
            if(produto != null)
            {
                /*
                ReadProdutoDto produtoDto = new ReadProdutoDto
                {
                    IdProduto = produto.IdProduto,
                    Descricao = produto.Descricao,
                    CodigoFornecedor = produto.CodigoFornecedor,
                    DescricaoFornecedor = produto.DescricaoFornecedor,
                    CNPJFornecedor = produto.CNPJFornecedor,
                    DataFab = produto.DataFab,
                    DataVal = produto.DataVal,
                    Flag = produto.Flag,
                    DataConsulta = DateTime.Now
                };
                */
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);

                return Ok(produtoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
        {
            
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.IdProduto == id);
            int validador = DateTime.Compare(produtoDto.DataFab, produtoDto.DataVal);
            if (validador <= 0 && produto != null)
            {
                /*
                produto.Descricao = produtoDto.Descricao;
                produto.CodigoFornecedor = produtoDto.CodigoFornecedor;
                produto.DescricaoFornecedor = produtoDto.DescricaoFornecedor;
                produto.CNPJFornecedor = produtoDto.CNPJFornecedor;
                produto.DataFab = produtoDto.DataFab;
                produto.DataVal = produtoDto.DataVal;
                */
                _mapper.Map(produtoDto, produto);
                _context.SaveChanges();
                return NoContent();
                
            }
            return NotFound();        

        }

        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.IdProduto == id);
            if (produto == null)
            {
                return NotFound();
            }
            produto.Flag = 0;
            //_context.Remove(produto);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
