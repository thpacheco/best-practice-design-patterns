namespace Chain.Of.Resposibility.Descontos
{
    public class SemDesconto : IDescontos
    {
        public IDescontos ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
