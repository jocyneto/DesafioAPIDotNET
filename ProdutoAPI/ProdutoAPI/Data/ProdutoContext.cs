using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> opt) : base(opt)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

    }
}
