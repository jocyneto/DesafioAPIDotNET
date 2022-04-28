using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Descrição do produto é obrigatório.")]
        public string Descricao { get; set; }

        [Range(0,1, ErrorMessage = "O campo deve ser 0 = Inativo ou 1 = Ativo.")]
        public int Flag { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataFab { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataVal { get; set; }        
        public string CodigoFornecedor { get; set; }        
        public string DescricaoFornecedor { get; set; }        
        public string CNPJFornecedor { get; set; }

    }
}
