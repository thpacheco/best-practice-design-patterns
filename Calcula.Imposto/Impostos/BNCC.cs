using Calcula.Imposto.Contracts;

namespace Calcula.Imposto.Impostos
{
    public class BNCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor + 1000;
        }
    }
}
