namespace Chain.Of.Resposibility.Descontos
{
    public class DescontoPorMaisQuinhetosReais : IDescontos
    {
        public IDescontos ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
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
