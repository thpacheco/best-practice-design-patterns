using Calcula.Imposto.Contracts;
using Calcula.Imposto.Impostos;
using System;

namespace Calcula.Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de impostos!");

            IImposto inss = new INSS();
            IImposto iss = new ISS();
            IImposto bncc = new BNCC();

            Orcamento orcamento = new Orcamento(300);
            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

            calculadorDeImpostos.RealizaCalculo(orcamento, bncc);

            Console.ReadKey();
        }
    }
}
