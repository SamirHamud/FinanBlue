namespace FinanBlue.Models
{
    public class CompraModel
    {
        public int cod_produto { get; set; }
        public int cod_empresa { get; set; }
        public double quantidade_compra { get; set; }
        public decimal valor_compra { get; set; }
    }
}
