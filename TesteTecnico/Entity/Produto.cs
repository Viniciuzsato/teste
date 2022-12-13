namespace TesteTecnico.Entity
{
    public class Produto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Descricao { get; set; }
        public string? CodigoBarras { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal  PesoLiquido { get; set; }
    }
}
