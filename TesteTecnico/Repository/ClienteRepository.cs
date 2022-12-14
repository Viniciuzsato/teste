using TesteTecnico.Context;
using TesteTecnico.Entity;
using TesteTecnico.Repository.Interface;

namespace TesteTecnico.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _appDbContext;
        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Adicionar(Cliente cliente)
        {
            _ = _appDbContext.Cliente.Add(cliente);
            _appDbContext.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            _ = _appDbContext.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Deletar(Cliente cliente)
        {
            _ = _appDbContext.Cliente.Remove(cliente);
            _appDbContext.SaveChanges();
        }

        public List<Cliente> Obter()
        {
            return _appDbContext.Cliente.ToList();

        }

        public Cliente ObterPorId(int clienteId)
        {
            return _appDbContext.Cliente.FirstOrDefault();
        }
    }
}
