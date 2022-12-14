using System.Linq;
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
            _ = _appDbContext.Produto.Add(produto);
            _appDbContext.SaveChanges();
        }

        public void Alterar(Produto produto)
        {
            _appDbContext.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Deletar(Produto produto)
        {

            _ = _appDbContext.Produto.Remove(produto);
            _appDbContext.SaveChanges();
        }

        public List<Produto> Obter()
        {
            return _appDbContext.Produto.ToList();
            
        }

        public Produto ObterPorId(int produtoId)
        {
            return _appDbContext.Produto.FirstOrDefault();
        }
    }
}
