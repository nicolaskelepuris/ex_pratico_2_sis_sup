using System;

namespace src.Investimentos
{
    public class Investimento : IInvestimento
    {
        public decimal Montante { get; private set; }
        public decimal JurosAnual { get; private set; }
        public int PeriodoInvestimentoAnos { get; private set; }
        public Investimento(decimal montante, decimal jurosAnual, int periodoInvestimentoAnos)
        {
            Montante = montante;
            JurosAnual = jurosAnual;
            PeriodoInvestimentoAnos = periodoInvestimentoAnos;
        }

        public decimal MontanteJurosSimples()
        {
            var acrescimo = Montante * JurosAnual * PeriodoInvestimentoAnos;
            var montanteFinal = Montante + acrescimo;
            
            return montanteFinal;
        }
    }
}