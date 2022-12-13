using TesteTecnico.Entity;
using TesteTecnico.Repository;
using TesteTecnico.Repository.Interface;
using TesteTecnico.Service.Interface;

namespace TesteTecnico.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void Adicionar(Cliente cliente)
        {
            if (cliente is not null)
                _clienteRepository.Adicionar(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            if (cliente is not null)
                _clienteRepository.Alterar(cliente);
        }

        public void Deletar(Cliente cliente)
        {
            if (cliente is not null)
                _clienteRepository.Deletar(cliente);
        }

        public List<Produto> Obter()
        {
            throw new NotImplementedException();
        }

        public Produto ObterPorId(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
