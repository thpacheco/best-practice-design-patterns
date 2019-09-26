using Calcula.Imposto.Contracts;

namespace Calcula.Imposto.Impostos
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5;
        }
    }
}
