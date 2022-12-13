using TesteTecnico.Entity;

namespace TesteTecnico.Repository.Interface
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(int clienteId);
        Produto ObterPorId(int clienteId);
        List<Cliente> Obter();
    }

}
