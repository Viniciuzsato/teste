using TesteTecnico.Models;

namespace TesteTecnico.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(ClienteModel model)
        {
            if (model is null)
                return;

            Codigo = model.Codigo;
            Nome = model.Nome;
            Fantasia = model.Fantasia;
            Documento = model.Documento;
            Endereco = model.Endereco;

        }
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Fantasia { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
    }
}
