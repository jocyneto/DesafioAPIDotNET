using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdutoAPI.Migrations
{
    public partial class TesteDoisBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Flag = table.Column<int>(type: "int", nullable: false),
                    DataFab = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataVal = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CodigoFornecedor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DescricaoFornecedor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CNPJFornecedor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.IdProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
