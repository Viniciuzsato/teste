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
            _ = _appDbContext.Clientes.Add(cliente);
            _appDbContext.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            _ = _appDbContext.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Deletar(int cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Obter()
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
