using Calcula.Imposto.Contracts;

namespace Calcula.Imposto.Impostos
{
    public class INSS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
