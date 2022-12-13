using TesteTecnico.Entity;

namespace TesteTecnico.Service.Interface
{
    public interface IClienteService
    {
        void Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Deletar(Cliente cliente);
        Produto ObterPorId(int clienteId);
        List<Produto> Obter();
    }
}
