using TesteTecnico.Context;
using TesteTecnico.Entity;
using TesteTecnico.Repository.Interface;

namespace TesteTecnico.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProdutoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Adicionar(Produto produto)
        {
            _ = _appDbContext.Produtos.Add(produto);
            _appDbContext.SaveChanges();
        }

        public void Alterar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int produtoId)
        {
            throw new NotImplementedException();
        }

        public List<Produto> Obter()
        {
            throw new NotImplementedException();
        }

        public Produto ObterPorId(int produtoId)
        {
            throw new NotImplementedException();
        }
    }
}
