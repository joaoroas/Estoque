using System.Collections.Generic;

namespace Estoque.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public int CategoriaId { get; set; }

        public Categoria  Categoria { get; set; }

        public int MyProperty { get; set; }

        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}