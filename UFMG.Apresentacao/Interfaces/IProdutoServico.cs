using UFMG.Apresentacao.Entities;

namespace UFMG.Apresentacao.Interfaces
{
    public interface IProdutoServico
    {
        IEnumerable<Produto> ObterTodos();
        Produto ObterPorCodigoBarra(string codigoBarra);
    }
}
