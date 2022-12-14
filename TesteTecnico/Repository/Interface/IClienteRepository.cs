using TesteTecnico.Entity;

namespace TesteTecnico.Repository.Interface
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(Cliente clienteId);
        Cliente ObterPorId(int clienteId);
        List<Cliente> Obter();
    }

}
