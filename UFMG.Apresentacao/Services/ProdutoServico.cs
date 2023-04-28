using UFMG.Apresentacao.Entities;
using UFMG.Apresentacao.Exceptions;
using UFMG.Apresentacao.Interfaces;

namespace UFMG.Apresentacao.Services
{
    public sealed class ProdutoServico : IProdutoServico
    {
        private readonly List<Produto> _lista = new List<Produto>()
        {
            new Produto()
            {
                CodigoBarra = "100001",
                Descricao = "Coca-cola 350ml",
                Valor = 4.99m,
            },
        };

        public Produto ObterPorCodigoBarra(string codigoBarra)
        {
            var produto = _lista.FirstOrDefault(x => x.CodigoBarra == codigoBarra);

            if (produto == null)
                throw new NotFoundException("Produto não encontrado");

            return produto;
        }

        public IEnumerable<Produto> ObterTodos() => _lista;
    }
}
