using TesteTecnico.Entity;

namespace TesteTecnico.Service.Interface
{
    public interface IClienteService
    {
        void Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(Cliente cliente);
        Cliente ObterPorId(int clienteId);
        List<Cliente> Obter();
    }
}
