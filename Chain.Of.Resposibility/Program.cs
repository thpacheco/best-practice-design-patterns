using System;

namespace Chain.Of.Resposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implentando Chain of Responsibility");

             CalcularDeDescontos calcularDeDescontos = new CalcularDeDescontos();

            Orcamento orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 500));
            orcamento.AdicionaItem(new Item("Lapis", 500));
            orcamento.AdicionaItem(new Item("Lapis", 500));

            double desconto = calcularDeDescontos.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
