using System.Collections.Generic;

namespace Chain.Of.Resposibility
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Items { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Items = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Items.Add(item);
        }
    }
}
