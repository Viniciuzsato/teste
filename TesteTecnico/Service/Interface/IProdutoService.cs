using TesteTecnico.Entity;

namespace TesteTecnico.Service.Interface
{
    public interface IProdutoService
    {
        void Adicionar(Produto produto);
        void Alterar(Produto produto);
        void Deletar(Produto produto);
        Produto ObterPorId(int produtoId);
        List<Produto> Obter();
    }
}
