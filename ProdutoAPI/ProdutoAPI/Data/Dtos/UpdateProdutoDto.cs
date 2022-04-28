using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Data.Dtos
{
    public class UpdateProdutoDto
    {
        
        [Required(ErrorMessage = "Descrição do produto é obrigatório.")]
        public string Descricao { get; set; }

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
