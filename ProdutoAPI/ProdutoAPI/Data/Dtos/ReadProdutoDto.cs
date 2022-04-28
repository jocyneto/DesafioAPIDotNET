using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoAPI.Data.Dtos
{
    public class ReadProdutoDto
    {

        [Key]
        [Required]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Descrição do produto é obrigatório.")]
        public string Descricao { get; set; }

        [Range(0, 1, ErrorMessage = "O campo deve ser 0 = Inativo ou 1 = Ativo.")]
        public int Flag { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataFab { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataVal { get; set; }

        //[Required(ErrorMessage = "Id do fornecedor é obrigatório.")]
        public string CodigoFornecedor { get; set; }

        //[Required(ErrorMessage = "Descrição do fornecedor é obrigatório.")]
        public string DescricaoFornecedor { get; set; }

        //[Required(ErrorMessage = "CNPJ do fornecedor é obrigatório.")]
        public string CNPJFornecedor { get; set; }

        public DateTime DataConsulta { get; set; }

    }
}
