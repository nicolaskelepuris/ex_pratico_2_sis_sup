using System;
using src.Investimentos;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var investimento = new Investimento(jurosAnual: 0.1m, montante: 10000, periodoInvestimentoAnos: 15);
            Console.WriteLine($"Montante ao final do periodo considerando juros compostos: {investimento.MontanteJurosCompostos()}");
        }
    }
}
