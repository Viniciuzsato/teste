using TesteTecnico.Entity;

namespace TesteTecnico.Repository.Interface
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        void Alterar(Produto produto);
        void Deletar(Produto produto);
        Produto ObterPorId(int produtoId);
        List<Produto> Obter();
    }
}
