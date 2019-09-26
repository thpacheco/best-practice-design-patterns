using System.Linq;

namespace Chain.Of.Resposibility.Descontos
{
    public class SomaDosItensMaiorQueMil : IDescontos
    {
        public IDescontos ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Items.Sum(c => c.Valor) > 1000)
            {
                return orcamento.Valor * 0.50;
            }
            else
            {
                return ProximoDesconto.Desconta(orcamento);
            }
        }
    }
}
