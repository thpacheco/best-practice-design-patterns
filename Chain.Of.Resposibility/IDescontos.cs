namespace Chain.Of.Resposibility
{
    public interface IDescontos
    {
        double Desconta(Orcamento orcamento);
        public IDescontos ProximoDesconto { get; set; }
    }
}
