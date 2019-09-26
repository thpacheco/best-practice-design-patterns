using Chain.Of.Resposibility.Descontos;

namespace Chain.Of.Resposibility
{
    public class CalcularDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDescontos cintoItens = new DescontoPorCincoItems();
            IDescontos maisQuientosReais = new DescontoPorMaisQuinhetosReais();
            IDescontos itemMaiorQueMil = new SomaDosItensMaiorQueMil();
            IDescontos semDesconto = new SemDesconto();

            cintoItens.ProximoDesconto = maisQuientosReais;
            maisQuientosReais.ProximoDesconto = itemMaiorQueMil;
            itemMaiorQueMil.ProximoDesconto = semDesconto;

            return cintoItens.Desconta(orcamento);
        }
    }
}
