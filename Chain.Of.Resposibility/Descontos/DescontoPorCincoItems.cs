namespace Chain.Of.Resposibility.Descontos
{
    public class DescontoPorCincoItems : IDescontos
    {
        public IDescontos ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Items.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else
            {
                return ProximoDesconto.Desconta(orcamento);
            }
        }
    }
}
